using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Dtos
{
	public class UserDto
	{
	}

	public class UserLoginDto
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
}
