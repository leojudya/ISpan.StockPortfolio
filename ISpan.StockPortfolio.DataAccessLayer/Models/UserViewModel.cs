using System.ComponentModel.DataAnnotations;

namespace ISpan.StockPortfolio.DataAccessLayer.Models
{
	public class UserLoginViewModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}

	public class UserSignUpViewModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}

}
