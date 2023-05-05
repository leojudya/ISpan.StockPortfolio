using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;
using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using ISpan.StockPortfolio.DataAccessLayer.Core;
using AutoMapper;
using ISpan.StockPortfolio.Common;


namespace ISpan.StockPortfolio.Services
{
	public class UserService
	{
		private static UserRepository _userRepository = new UserRepository();
		private static MapperConfiguration _mapperConfiguration;
		private static IMapper _mapper;

		public UserService()
		{
			_mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
			_mapper = _mapperConfiguration.CreateMapper();
		}

		public bool VerifyPassword(string email, string password)
		{
			UserDto user = GetLoginUser(email);
			if (user == null)
				return false;

			return BC.Verify(password, user.Password);
		}

		public UserDto GetLoginUser(string email)
		{
			return _mapper.Map<UserDto>(_userRepository.Get(email));
		}

		public int Create(UserSignUpDto dto)
		{
			return _userRepository.Insert(_mapper.Map<User>(dto));
		}


	}
}
