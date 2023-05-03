using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using Microsoft.AspNetCore.WebUtilities;

namespace ISpan.StockPortfolio.Services
{
	public class StockService
	{
		private static StockRepository _stockRepository = new StockRepository();
		public IEnumerable<StockDto> GetAllStock()
		{
			return _stockRepository.Search();
		}
	}
}
