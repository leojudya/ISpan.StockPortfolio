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

namespace ISpan.StockPortfolio.Services
{
	public class TwseStockInfoService
	{
		private static readonly string apiUrl = "https://mis.twse.com.tw/stock/api/getStockInfo.jsp";
		private static readonly HttpClient client = new HttpClient();
		private async Task<string> FetchStocks(IEnumerable<string> symbols)
		{
			string exchQuery = TwseUrlHelper.GetExCh(symbols);
			string url = TwseUrlHelper.GetUrl(apiUrl, exchQuery);

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

			var config = new MapperConfiguration(cfg =>
				cfg.CreateMap<StockRawInfo, TwseStockInfoDto>()
			   .ForMember(x => x.Symbol, y => y.MapFrom(o => o.c))
			   .ForMember(x => x.Name, y => y.MapFrom(o => o.n))
			   .ForMember(x => x.OpeningPrice, y => y.MapFrom(o => o.o))
			   .ForMember(x => x.HighestPrice, y => y.MapFrom(o => o.h))
			   .ForMember(x => x.LowestPrice, y => y.MapFrom(o => o.l))
			   .ForMember(x => x.MarketPrice, y => y.MapFrom(o => o.z))
			   .ForMember(x => x.BidPrice, y => y.MapFrom(o => o.a.Split('_')[0]))
			   .ForMember(x => x.AskPrice, y => y.MapFrom(o => o.b.Split('_')[0]))
			   .ForMember(x => x.TradingVolume, y => y.MapFrom(o => o.v))
			   .ForMember(x => x.LastUpdated, y => y.MapFrom(o => DateTime.ParseExact($"{o.d} {o.t}", "yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture)))
			);


			var mapper = config.CreateMapper();
			var result = mapper.Map<IEnumerable<TwseStockInfoDto>>(msgArray);

			return result;
		}

		public async Task<IEnumerable<TwseStockInfoDto>> Test(IEnumerable<string> symbols)
		{
			var json = await FetchStocks(symbols);
			return ParseStocks(json);
		}
	}
}
