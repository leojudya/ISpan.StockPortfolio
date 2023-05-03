using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.Services
{
	public class ValidatorHelper
	{
		public static bool ValidEmailAddress(string emailAddress, out string errorMessage)
		{
			// Confirm that the email address string is not empty.
			if (emailAddress.Length == 0)
			{
				errorMessage = "email address is required.";
				return false;
			}

			// Confirm that there is an "@" and a "." in the email address, and in the correct order.
			if (emailAddress.IndexOf("@") > -1)
			{
				if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
				{
					errorMessage = "";
					return true;
				}
			}

			errorMessage = "email address must be valid email address format.\n" +
			   "For example 'someone@example.com' ";
			return false;
		}

	}
}
