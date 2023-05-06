﻿using Dapper;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.StockPortfolio.DataAccessLayer.Core;

namespace ISpan.StockPortfolio.DataAccessLayer
{
	public class PortfolioRepository
	{
		private static IConnectionFactory _connectionFactory = new SqlServerConnectionFactory();

        public IEnumerable<Portfolio> Search(int userId)
        {
			string sql = @"SELECT
                          p.*,
                          s.[StockSymbol] AS [Symbol],
                          s.[StockTypeId]
                        FROM
                          Portfolio p
                          JOIN Stocks s ON p.StockId = s.Id
                        WHERE
                          UserId = @UserId;";

			using (var conn = _connectionFactory.GetConnection())
			{
				return conn.Query<Portfolio>(sql, new { UserId = userId });
			}

		}

		public Portfolio Get(int id)
        {
            string sql = @"SELECT * FROM Portfolio WHERE Id = @Id";

			using (var conn = _connectionFactory.GetConnection())
			{
				return conn.Query<Portfolio>(sql, new {Id = id}).FirstOrDefault();
			}

		}

		public int Insert(PortfolioAddDto dto)
		{
            #region SQL Statement
            string sql =
                 @"INSERT INTO
                        Portfolio(
                            [UserId],
                            [StockId],
                            [Quantity],
                            [Price],
                            [PurchaseDate]
                        )
                    VALUES
                        (@UserId, @StockId, @Quantity, @Price, @PurchaseDate);"; 
            #endregion

            using (var conn = _connectionFactory.GetConnection())
            {
                return conn.Execute(sql, dto);
            }
        }

        public int Delete(int id)
        {
            string sql = @"DELETE FROM Portfolio WHERE Id = @Id";

            using (var conn = _connectionFactory.GetConnection())
            {
                return conn.Execute(sql, new { Id = id });
            }
        }

        public int Update(PortfolioEditDto dto)
        {
            string sql = @"UPDATE
                                Portfolio
                            SET
                                [Quantity] = @Quantity,
                                [Price] = @Price,
                                [PurchaseDate] = @PurchaseDate
                            WHERE
                                Id = @Id;";

            using (var conn = _connectionFactory.GetConnection())
            {
                return conn.Execute(sql, dto);
            }
        }
	}
}
