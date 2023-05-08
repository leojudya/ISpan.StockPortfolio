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

		public void CreateForgetPassword(string email)
		{
			var user = GetLoginUser(email);
			if (user == null)
				return;

			_userRepository.CreateForgetPassword(email, user.Id);
			var code = _userRepository.GetForgetPassword(email).Guid.ToString();
			ForgetPasswordHelper.SendVerificationCode(code, email);
		}

		public bool VerifyForgetPassword(string email, string code)
		{
			var forgetPassword = _userRepository.GetForgetPassword(email);
			if (forgetPassword == null)
				return false;
			if (forgetPassword.ExpiryTime < System.DateTime.Now)
				return false;

			var dbGuid = forgetPassword.Guid.ToString().ToLower();

			return dbGuid.Equals(code.ToLower());
		}

		public void DeleteForgetPassword(string email)
		{
			_userRepository.DeleteForgetPassword(email);
		}

		public void UpdatePassword(string email, string password)
		{
			_userRepository.UpdatePassword(email, BC.HashPassword(password));
		}
	}
}
