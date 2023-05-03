using NUnit.Framework;
using ISpan.StockPortfolio.DataAccessLayer;
using System.Text.Json;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using System.Configuration;
using System.Data;
using AutoMapper;
using System.Collections.Generic;

namespace ISpan.StockPortfolio.UnitTests
{
	
	public class StockRepositoryUnitTest
	{
		private StockRepository _stockRepository = new StockRepository();
		[SetUp]
		public void Setup()
		{
			SqlServerConnectionFactory.SetConnectionString("Data Source=.;Initial Catalog=ISpanStockPortfolio;User ID=sa5;Password=sa5;Connect Timeout=30;Encrypt=False;");
		}

		[Test]
		public void ����Search���Ҧ����Ѳ��M��()
		{
			var stocks = _stockRepository.Search();
			Assert.That(stocks != null);
		}

		[Test]
		public void ����INSERT()
		{
		}

		[Test]
		public void ����DELETE()
		{
		}

		[Test]
		public void ����UPDATE()
		{
		}
	}
}