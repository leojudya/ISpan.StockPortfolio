using NUnit.Framework;
using ISpan.StockPortfolio.DataAccessLayer;
using System.Text.Json;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using System.Configuration;
using System.Data;

namespace ISpan.StockPortfolio.UnitTests
{
	
	public class Tests
	{
		private UserRepository _userRepository = new UserRepository();
		[SetUp]
		public void Setup()
		{
			ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
		}

		[Test]
		public void ´ú¸ÕGET()
		{
			var user = JsonSerializer.Serialize(_userRepository.Get("atuny0@sohu.com"));
			var expectedUser = JsonSerializer.Serialize(new UserLoginDto()
			{
				Id = 1,
				Email = "atuny0@sohu.com",
				Password = "9uQFF1Lh"
			});

			Assert.That(user == expectedUser);
		}
	}
}