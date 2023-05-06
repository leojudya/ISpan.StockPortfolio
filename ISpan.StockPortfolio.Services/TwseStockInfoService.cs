using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using AutoMapper;
using System.Globalization;
using ISpan.StockPortfolio.Common;

namespace ISpan.StockPortfolio.Services
{
	public class TwseStockInfoService
	{
		private static readonly string apiTwseUrl = "https://mis.twse.com.tw/stock/api/getStockInfo.jsp";
		private static readonly HttpClient client = new HttpClient();
		private static MapperConfiguration _mapperConfiguration;
		private static IMapper _mapper;

		public TwseStockInfoService()
		{
			_mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
			_mapper = _mapperConfiguration.CreateMapper();
		}
		private async Task<string> FetchStocks(IEnumerable<string> symbols)
		{
			string exchQuery = TwseUrlHelper.GetExCh(symbols);
			string url = TwseUrlHelper.GetUrlWithQueryString(apiTwseUrl, exchQuery);

			return await FetchDataString(url);
		}


		private async Task<string> FetchDataString(string url)
		{
			try
			{
				using (HttpResponseMessage response = await client.GetAsync(url))
				{
					response.EnsureSuccessStatusCode();
					string responseBody = await response.Content.ReadAsStringAsync();
					return responseBody;
				}
			}
			catch (HttpRequestException e)
			{
				Console.WriteLine("\nException Caught!");
				Console.WriteLine("Message :{0} ", e.Message);
			}
			return string.Empty;
		}

		private IEnumerable<TwseStockInfoDto> ParseStocks(string json)
		{
			var stockRoot = JsonSerializer.Deserialize<StockRoot>(json);
			var msgArray = stockRoot.msgArray;

			return _mapper.Map<IEnumerable<TwseStockInfoDto>>(msgArray);
		}


		public async Task<IEnumerable<TwseStockInfoDto>> GetRealtimeStocksInfo(IEnumerable<string> symbols)
		{
			var json = await FetchStocks(symbols);
			return ParseStocks(json);
		}

	}
}
