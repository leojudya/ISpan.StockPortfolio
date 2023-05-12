using System;
using System.Text.RegularExpressions;

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

		public static bool ValidBuyPrice(string buyPrice, out string errorMessage)
		{
			if (string.IsNullOrEmpty(buyPrice))
			{
				errorMessage = "價格不得為空!";
				return false;
			}
			if (!decimal.TryParse(buyPrice, out decimal p))
			{
				errorMessage = "價格格式錯誤";
				return false;
			}

			Regex regex = new Regex(@"^\d{1,16}\.*\d{0,2}$");
			if (!regex.IsMatch(buyPrice))
			{
				errorMessage = "價格格式錯誤";
				return false;
			}

			errorMessage = "";
			return true;
		}

		public static bool IsValidPositiveInt32(string quantity, out string errorMessage)
		{
			if (string.IsNullOrEmpty(quantity))
			{
				errorMessage = "數量不得為空!";
				return false;
			}
			if (!int.TryParse(quantity, out int p))
			{
				errorMessage = "數量格式錯誤";
				return false;
			}
			if (p < 1)
			{
				errorMessage = "數量不能小於一!";
				return false;
			}

			//try
			//{
			//	int.Parse(quantity);
			//}
			//catch (OverflowException ex)
			//{
			//	errorMessage = ex.Message;
			//	return false;
			//}

			errorMessage = "";
			return true;
		}


	}
}
