namespace ISpan.StockPortfolio.DataAccessLayer.Dtos
{
	public class UserDto
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}

	public class UserSignUpDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}

	public class UserLoginDto
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
