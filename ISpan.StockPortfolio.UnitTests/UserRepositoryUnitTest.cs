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
	
	public class UserRepositoryUnitTest
	{
		private UserRepository _userRepository = new UserRepository();
		[SetUp]
		public void Setup()
		{
			SqlServerConnectionFactory.SetConnectionString("Data Source=.;Initial Catalog=ISpanStockPortfolio;User ID=sa5;Password=sa5;Connect Timeout=30;Encrypt=False;");
		}

		[Test]
		public void 測試GET()
		{
			var user = JsonSerializer.Serialize(_userRepository.Get("atuny0@sohu.com"));
			var expectedUser = JsonSerializer.Serialize(new UserDto()
			{
				Id = 1,
				Email = "atuny0@sohu.com",
				Password = "9uQFF1Lh"
			});

			Assert.That(user == expectedUser);
		}

		[Test]
		public void 測試INSERT()
		{
			var mock = new UserSignUpDto()
			{
				Email = "leojudya@gmail.com",
				Password = "qwerty"
			};

			_userRepository.Insert(mock);

			var dbUser = _userRepository.Get("leojudya@gmail.com");
			_userRepository.Delete(dbUser.Id);

			var config = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, UserSignUpDto>()); 
			config.AssertConfigurationIsValid(); 
			var mapper = config.CreateMapper(); 
			var result = mapper.Map<UserSignUpDto>(dbUser);

			var user = JsonSerializer.Serialize(result);
			var expectedUser = JsonSerializer.Serialize(mock);

			Assert.That(user == expectedUser);
		}

		[Test]
		public void 測試DELETE()
		{
			var mock = new UserSignUpDto()
			{
				Email = "leojudya@gmail.com",
				Password = "qwerty"
			};

			_userRepository.Insert(mock);

			var dbUser = _userRepository.Get("leojudya@gmail.com");
			var affectedRows = _userRepository.Delete(dbUser.Id);

			Assert.That(affectedRows, Is.GreaterThan(0));
		}

		[Test]
		public void 測試UPDATE()
		{
			var mock = new UserSignUpDto()
			{
				Email = "leojudya@gmail.com",
				Password = "qwerty"
			};

			_userRepository.Insert(mock);
			var dbUser = _userRepository.Get("leojudya@gmail.com");
			_userRepository.Update(new UserDto
			{
				Id = dbUser.Id,
				Email = "leojudya@gmail.com",
				Password = "12345"
			});
			var dbUpdatedUser = _userRepository.Get("leojudya@gmail.com");

			_userRepository.Delete(dbUser.Id);

			var user = JsonSerializer.Serialize(dbUpdatedUser);
			var expectedUser = JsonSerializer.Serialize(new UserDto
			{
				Id = dbUser.Id,
				Email = "leojudya@gmail.com",
				Password = "12345"
			});

			Assert.That(user == expectedUser);

		}

		[Test]
		public void 密碼驗證()
		{
			var user = _userRepository.Get("atuny0@sohu.com");
			var hashedPassword = user.Password;

			Assert.That(BCrypt.Net.BCrypt.Verify("9uQFF1Lh", hashedPassword));
		}
	}
}