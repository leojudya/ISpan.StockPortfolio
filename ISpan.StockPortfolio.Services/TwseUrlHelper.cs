using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.Services
{
	public static class TwseUrlHelper
	{
		public static string GetUrlWithQueryString(string apiUrl, string exCh)
		{
			var queryParameters = new Dictionary<string, string>
			{
				{"ex_ch", exCh },
				{"json",  "1"},
				{"delay", "0" }
			};

			var url = QueryHelpers.AddQueryString(apiUrl, queryParameters);

			return url;
		}

		/// <summary>
		/// 產生查詢股票代碼的查詢字串
		/// </summary>
		/// <returns></returns>
		public static string GetExCh(IEnumerable<string> symbols)
		{
			return string.Join("|", symbols.Select(symbol => $"tse_{symbol}.tw"));
		}
	}

}
