using ISpan.StockPortfolio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.StockPortfolio.App
{
	public partial class FormEditPassword : Form
	{
		private readonly UserService _service;
		private readonly string _email;
		public FormEditPassword(string email)
		{
			InitializeComponent();
			_service = new UserService();
			_email = email;
		}

		private void textBoxPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxPassword.Text))
			{
				// Cancel the event and select the text to be corrected by the user.
				e.Cancel = true;
				textBoxPassword.Select(0, textBoxPassword.Text.Length);

				// Set the ErrorProvider error with the text to display. 
				this.errorProvider1.SetError(textBoxPassword, "Password cannot be empty!");
			}

			if (textBoxPassword.Text != textBoxConfirmPassword.Text)
			{
				// Cancel the event and select the text to be corrected by the user.
				e.Cancel = true;
				textBoxPassword.Select(0, textBoxPassword.Text.Length);

				// Set the ErrorProvider error with the text to display. 
				this.errorProvider1.SetError(textBoxPassword, "You entered different password!");
			}

		}

		private void textBoxPassword_Validated(object sender, EventArgs e)
		{
			errorProvider1.SetError(textBoxPassword, "");
		}

		private void FormEditPassword_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Close();
			e.Cancel = false;
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
			{
				MessageBox.Show("密碼錯誤!");
				return;
			}

			_service.UpdatePassword(_email, textBoxPassword.Text);
			this.Close();
		}
	}
}
