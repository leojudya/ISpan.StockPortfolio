using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Core
{
	public class User
	{
		public int Id { get; private set; }
		public string Email { get; private set; }
		public string Password { get; private set; }

		public User() { }

		public User(string email, string password, int id = 0) 
		{
			// TO-DO
			// precondition check

			Id = id;
			Email = email;
			Password = password;
		}
	}
}
