using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using System.Collections.Generic;

namespace ISpan.StockPortfolio.DataAccessLayer
{
	public interface IStockRepository
	{
		int Delete(int stockId);
		StockDto GetByName(string name);
		StockDto GetBySymbol(string symbol);
		IEnumerable<StockDto> Search();
		int Update(StockDto stock);
	}
}