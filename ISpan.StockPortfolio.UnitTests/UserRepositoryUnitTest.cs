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
		public void 代刚GET()
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

		[Test]
		public void 代刚INSERT()
		{
			var mock = new UserSignUpDto()
			{
				Email = "leojudya@gmail.com",
				Password = "qwerty"
			};

			_userRepository.Insert(mock);

			var dbUser = _userRepository.Get("leojudya@gmail.com");
			_userRepository.Delete(dbUser.Id);

			var config = new MapperConfiguration(cfg => cfg.CreateMap<UserLoginDto, UserSignUpDto>()); 
			config.AssertConfigurationIsValid(); 
			var mapper = config.CreateMapper(); 
			var result = mapper.Map<UserSignUpDto>(dbUser);

			var user = JsonSerializer.Serialize(result);
			var expectedUser = JsonSerializer.Serialize(mock);

			Assert.That(user == expectedUser);
		}

		[Test]
		public void 代刚DELETE()
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
		public void 代刚UPDATE()
		{
			var mock = new UserSignUpDto()
			{
				Email = "leojudya@gmail.com",
				Password = "qwerty"
			};

			_userRepository.Insert(mock);
			var dbUser = _userRepository.Get("leojudya@gmail.com");
			_userRepository.Update(new UserLoginDto
			{
				Id = dbUser.Id,
				Email = "leojudya@gmail.com",
				Password = "12345"
			});
			var dbUpdatedUser = _userRepository.Get("leojudya@gmail.com");

			_userRepository.Delete(dbUser.Id);

			var user = JsonSerializer.Serialize(dbUpdatedUser);
			var expectedUser = JsonSerializer.Serialize(new UserLoginDto
			{
				Id = dbUser.Id,
				Email = "leojudya@gmail.com",
				Password = "12345"
			});

			Assert.That(user == expectedUser);

		}
	}
}