using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace ISpan.StockPortfolio.DataAccessLayer
{
	public static class DbConnectionBuilder
	{
		public static IDbConnection Create()
		{
			return CreateMSSQLConnection();
		}
		public static IDbConnection CreateMSSQLConnection()
		{
			var connStr = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
			return new SqlConnection(connStr);
		}

		// TO-DO mysql, sqlite3, postgre.....
	}
}
