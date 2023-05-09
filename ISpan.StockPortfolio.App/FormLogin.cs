using ISpan.StockPortfolio.Services;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ISpan.StockPortfolio.App
{
	public partial class FormLogin : Form
	{
		private static readonly UserService _userService = new UserService();
		public FormLogin()
		{
			InitializeComponent();
		}

		private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new FormSignUp();
			frm.ShowDialog();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{

			if (!ValidateChildren())
			{
				MessageBox.Show("Email 或 密碼格式錯誤!");
				return;
			}

			if (!_userService.VerifyPassword(textBoxEmail.Text, textBoxPassword.Text))
			{
				MessageBox.Show("密碼或電子郵件錯誤!");
				return;
			}

			var user = _userService.GetLoginUser(textBoxEmail.Text);

			textBoxEmail.Text = string.Empty;
			textBoxPassword.Text = string.Empty;

			var frm = new FormPortfolio(user.Id);
			frm.Owner = this;
			this.Hide();
			frm.ShowDialog();
		}



		private void textBoxEmail_Validating(object sender, CancelEventArgs e)
		{
			string errorMsg;
			if (!ValidatorHelper.ValidEmailAddress(textBoxEmail.Text, out errorMsg))
			{
				// Cancel the event and select the text to be corrected by the user.
				e.Cancel = true;
				textBoxEmail.Select(0, textBoxEmail.Text.Length);

				// Set the ErrorProvider error with the text to display. 
				this.errorProvider1.SetError(textBoxEmail, errorMsg);
			}
		}

		private void textBoxEmail_Validated(object sender, EventArgs e)
		{
			errorProvider1.SetError(textBoxEmail, "");
		}

		private void textBoxPassword_Validating(object sender, CancelEventArgs e)
		{
			int minimumPasswordLength = 6;
			if (string.IsNullOrEmpty(textBoxPassword.Text))
			{
				// Cancel the event and select the text to be corrected by the user.
				e.Cancel = true;
				textBoxPassword.Select(0, textBoxPassword.Text.Length);

				// Set the ErrorProvider error with the text to display. 
				this.errorProvider1.SetError(textBoxPassword, "Password cannot be empty!");
			}

			if (textBoxPassword.Text.Length < minimumPasswordLength)
			{
				// Cancel the event and select the text to be corrected by the user.
				e.Cancel = true;
				textBoxPassword.Select(0, textBoxPassword.Text.Length);

				// Set the ErrorProvider error with the text to display. 
				this.errorProvider1.SetError(textBoxPassword, "密碼最少要六個字!");
			}
		}

		private void textBoxPassword_Validated(object sender, EventArgs e)
		{
			errorProvider1.SetError(textBoxPassword, "");
		}

		private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}

		private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				buttonLogin_Click(textBoxPassword, EventArgs.Empty);
			}
		}

		private void linkLabelForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new FormForgetPassword();
			frm.ShowDialog();
		}
	}
}
