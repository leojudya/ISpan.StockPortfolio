using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ISpan.StockPortfolio.DataAccessLayer
{
	interface IConnectionFactory
	{
		IDbConnection GetConnection();
	}

	public class SqliteConnectionFactory : IConnectionFactory
	{
		public IDbConnection GetConnection()
		{
			return new SqliteConnection();
		}
	}

	public class SqlServerConnectionFactory : IConnectionFactory
	{
		public IDbConnection GetConnection()
		{
			return new SqlConnection(GetConnectionString());
		}

		private string GetConnectionString() => ConfigurationManager.ConnectionStrings["SqlServer"].ToString();
	}
}
