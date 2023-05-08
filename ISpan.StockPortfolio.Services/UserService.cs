using AutoMapper;
using ISpan.StockPortfolio.Common;
using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Core;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using BC = BCrypt.Net.BCrypt;


namespace ISpan.StockPortfolio.Services
{
	public interface IUserService
	{
		int Create(UserSignUpDto dto);
		UserDto GetLoginUser(string email);
		bool VerifyPassword(string email, string password);
	}

	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		private static MapperConfiguration _mapperConfiguration;
		private static IMapper _mapper;

		public UserService()
		{
			_mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
			_mapper = _mapperConfiguration.CreateMapper();
			_userRepository = new UserRepository();
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
