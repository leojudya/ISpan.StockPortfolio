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
		private static string _connectionString = ConfigurationManager.ConnectionStrings["SqlServer"]?.ToString();
		public IDbConnection GetConnection()
		{
			return new SqlConnection(_connectionString);
		}

		public static void SetConnectionString(string connectionString) => _connectionString = connectionString;
		
	}
}
