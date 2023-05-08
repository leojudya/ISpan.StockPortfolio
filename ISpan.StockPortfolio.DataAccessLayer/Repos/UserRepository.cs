using Dapper;
using ISpan.StockPortfolio.DataAccessLayer.Core;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using System.Data;
using System.Security.Cryptography;

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

		public void CreateForgetPassword(string email, int userId)
		{
			using (var conn = DbConnectionBuilder.Create())
			{
				DynamicParameters parameters = new DynamicParameters();
				parameters.Add("Email", email);
				parameters.Add("UserId", userId);
				conn.Execute("CreateForgetPassword", parameters, commandType: CommandType.StoredProcedure);
			}

		}

		public ForgetPassword GetForgetPassword(string email)
		{
			string sql = @"SELECT * FROM ForgetPassword JOIN Users ON Users.Id = ForgetPassword.UserId WHERE Users.Email = @Email";

			using (var conn = DbConnectionBuilder.Create())
			{
				return conn.QueryFirstOrDefault<ForgetPassword>(sql, new { Email = email });
			}

		}
	}
}
