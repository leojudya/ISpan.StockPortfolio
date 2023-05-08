using MimeKit;
using MailKit.Net.Smtp;

namespace ISpan.StockPortfolio.Common
{
	public static class ForgetPasswordHelper
	{
		public static void SendVerificationCode(string code, string email)
		{

			var emailMessage = GetForgetPasswordMessage(code, email);

			using (var client = new SmtpClient())
			{
				client.Connect("smtp.gmail.com",
										  465,
										  useSsl: true);

				client.Authenticate("iamstupidpeople@gmail.com",
									"wrhbdeuarmoblfmw");
				client.Send(emailMessage);
				client.Disconnect(true);
			}
		}

		public static MimeMessage GetForgetPasswordMessage(string code, string email)
		{
			var emailMessage = new MimeMessage();
			var addressFrom = new MailboxAddress("StockPortfolioSystem",
												 "iamstupidpeople@gmail.com");
			var addressTo = new MailboxAddress("Dear User",
											   email);

			emailMessage.From.Add(addressFrom);
			emailMessage.To.Add(addressTo);
			emailMessage.Subject = "Forget Password - StockPortfolio";

			emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
			{
				Text = $"Your verification code: {code}",
			};

			return emailMessage;
		}
	}
}