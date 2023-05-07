using Dapper;
using ISpan.StockPortfolio.DataAccessLayer.Core;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using System.Data;

namespace ISpan.StockPortfolio.DataAccessLayer
{
	public class UserRepository : IUserRepository
	{
		public User Get(string email)
		{
			string sql = @"SELECT [Id], [Email], [Password] FROM Users WHERE [Email] = @Email";

			using (var conn = DbConnectionBuilder.Create())
			{
				var user = conn.QueryFirstOrDefault<User>(sql, new { Email = email });
				return user;
			}
		}

		public int Insert(User user)
		{
			string sql = @"INSERT INTO Users([Email], [Password], [CreatedTime]) VALUES (@Email, @Password, DEFAULT);";

			using (var conn = DbConnectionBuilder.Create())
			{
				return conn.Execute(sql, new { user.Email, user.Password });
			}
		}

		public int Delete(int userId)
		{
			string sql = @"DELETE FROM Users WHERE Id = @Id";

			using (var conn = DbConnectionBuilder.Create())
			{
				return conn.Execute(sql, new { Id = userId });
			}
		}

		public int Update(UserDto user)
		{
			string sql = @"UPDATE Users SET [Email] = @Email, [Password] = @Password WHERE Id = @Id;";

			using (var conn = DbConnectionBuilder.Create())
			{
				return conn.Execute(sql, new { user.Email, user.Password, user.Id });
			}
		}
	}
}
