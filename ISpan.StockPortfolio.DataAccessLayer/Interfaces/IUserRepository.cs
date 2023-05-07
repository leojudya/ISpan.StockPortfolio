using ISpan.StockPortfolio.DataAccessLayer.Core;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;

namespace ISpan.StockPortfolio.DataAccessLayer
{
	public interface IUserRepository
	{
		int Delete(int userId);
		User Get(string email);
		int Insert(User user);
		int Update(UserDto user);
	}
}