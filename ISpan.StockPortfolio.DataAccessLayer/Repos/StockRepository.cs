using Dapper;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer
{
	public class StockRepository
	{
		private static IConnectionFactory _connectionFactory = new SqlServerConnectionFactory();

		public IEnumerable<StockDto> Search()
		{
			string sql =
				@"SELECT
					s.[Id],
					[Name],
					[StockSymbol],
					[StockTypeId],
					[Type] AS [StockType]
				FROM
					Stocks s
					JOIN StockTypes st ON s.StockTypeId = st.Id";

			using (var conn = _connectionFactory.GetConnection())
			{
				return conn.Query<StockDto>(sql);
			}
		}

		public StockDto GetBySymbol(string symbol)
		{
			var sql =
				@"
				SELECT
					s.[Id],
					[Name],
					[StockSymbol],
					[StockTypeId],
					[Type] AS [StockType]
				FROM
					Stocks s
					JOIN StockTypes st ON s.StockTypeId = st.Id
				WHERE 
					StockSymbol = @Symbol;
				";

			using (var conn = _connectionFactory.GetConnection())
			{
				return conn.Query<StockDto>(sql, new { Symbol = symbol }).FirstOrDefault();
			}
		}

		public StockDto GetByName(string name)
		{
			var sql =
				@"
				SELECT
					s.[Id],
					[Name],
					[StockSymbol],
					[StockTypeId],
					[Type] AS [StockType]
				FROM
					Stocks s
					JOIN StockTypes st ON s.StockTypeId = st.Id
				WHERE 
					Name = @Name;
				";

			using (var conn = _connectionFactory.GetConnection())
			{
				return conn.Query<StockDto>(sql, new { Name = name }).FirstOrDefault();
			}
		}

		public int Delete(int stockId)
		{
			string sql = @"DELETE FROM Stocks WHERE Id = @Id";
			using (var conn = _connectionFactory.GetConnection())
			{
				return conn.Execute(sql, new { Id = stockId });
			}
		}

		public int Update(StockDto stock)
		{
			throw new NotImplementedException();
		}
	}
}
