using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.StockPortfolio.DataAccessLayer;

namespace ISpan.StockPortfolio.Services
{
	public class PortfolioService
	{
		private static readonly PortfolioRepository _portfolioRepository = new PortfolioRepository();

		public object GetPortfolio(int userId)
		{
			var portfolioDtos = _portfolioRepository.Search(userId);
			var symbols = portfolioDtos.Select(dto => dto.Symbol);

			
			return new object();
		}

		
	}
}
