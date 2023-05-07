using ISpan.StockPortfolio.DataAccessLayer.Core;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using System.Collections.Generic;

namespace ISpan.StockPortfolio.DataAccessLayer
{
	public interface IPortfolioRepository
	{
		int Delete(int id);
		Portfolio Get(int id);
		int Insert(PortfolioAddDto dto);
		IEnumerable<Portfolio> Search(int userId);
		int Update(PortfolioEditDto dto);
	}
}