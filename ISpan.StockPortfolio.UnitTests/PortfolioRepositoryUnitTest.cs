using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using NUnit.Framework;
using System.Linq;

namespace ISpan.StockPortfolio.UnitTests
{

	public class PortfolioRepositoryUnitTest
	{
		private PortfolioRepository _portfolioRepository = new PortfolioRepository();
		[SetUp]
		public void Setup()
		{
			SqlServerConnectionFactory.SetConnectionString("Data Source=.;Initial Catalog=ISpanStockPortfolio;User ID=sa5;Password=sa5;Connect Timeout=30;Encrypt=False;");
		}

		[Test]
		public void 代刚GET()
		{
			var ep = new PortfolioDto()
			{
				Id = 1,
				UserId = 1,
				StockId = 2,
				Price = 14.50m,
				Quantity = 1000,
				PurchaseDate = new System.DateTime(2023, 5, 3, 0, 0, 0)
			};

			var p = _portfolioRepository.Get(1);

			Assert.That(EqualtyHelper.AreEqual(ep, p));
		}

		[Test]
		public void 代刚INSERT()
		{
			var p = new PortfolioDto()
			{
				UserId = 1,
				StockId = 2,
				Price = 14.50m,
				Quantity = 1000,
				PurchaseDate = new System.DateTime(2023, 5, 3, 0, 0, 0)
			};
			var originalRows = _portfolioRepository.Search(1).Count();
			_portfolioRepository.Insert(p);
			var actualRows = _portfolioRepository.Search(1).Count();
			var expectedRows = originalRows + 1;

			Assert.That(actualRows, Is.EqualTo(expectedRows));
		}

		[Test]
		public void 代刚DELETE()
		{
			var originalRows = _portfolioRepository.Search(1).Count();
			_portfolioRepository.Delete(1);
			var actualRows = _portfolioRepository.Search(1).Count();
			var expectedRows = originalRows - 1;

			Assert.That(actualRows, Is.EqualTo(expectedRows));

		}

		[Test]
		public void 代刚UPDATE()
		{
			var p = new PortfolioDto()
			{
				UserId = 1,
				StockId = 2,
				Price = 14.50m,
				Quantity = 1000,
				PurchaseDate = new System.DateTime(2023, 5, 3, 0, 0, 0)
			};

			var newP = new PortfolioDto()
			{
				Id = 1,
				UserId = 1,
				StockId = 2,
				Price = 15.00m,
				Quantity = 1000,
				PurchaseDate = new System.DateTime(2023, 5, 3, 0, 0, 0)
			};

			_portfolioRepository.Update(newP);
			var dbP = _portfolioRepository.Get(1);

			Assert.That(dbP.Price, Is.EqualTo(newP.Price));
		}
	}
}