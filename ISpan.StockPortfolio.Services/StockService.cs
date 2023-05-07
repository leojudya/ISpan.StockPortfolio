using ISpan.StockPortfolio.Common;
using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using System.Collections.Generic;

namespace ISpan.StockPortfolio.Services
{
	public class StockService
	{
		private IStockRepository _stockRepository;
        public StockService()
        {
			_stockRepository = new StockRepository();
		}
        public IEnumerable<StockDto> GetAllStock()
		{
			return _stockRepository.Search();
		}
	}
}
