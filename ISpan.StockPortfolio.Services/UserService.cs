using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;
using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;


namespace ISpan.StockPortfolio.Services
{
	public class UserService
	{
		private static UserRepository _userRepository = new UserRepository();

		public bool VerifyPassword(string email, string password)
		{
			UserLoginDto user = GetLoginUser(email);
			if (user == null) 
				return false;

			return BC.Verify(password, user.Password);
		}

		public UserLoginDto GetLoginUser(string email)
		{
			return _userRepository.Get(email);
		}

		public int Insert(string email, string password)
		{
			var newUser = new UserSignUpDto()
			{
				Email = email,
				Password = BC.HashPassword(password)
			};

			return _userRepository.Insert(newUser);
		}


	}
}
