﻿using AutoMapper;
using ISpan.StockPortfolio.Common;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using ISpan.StockPortfolio.DataAccessLayer.Models;
using ISpan.StockPortfolio.Services;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace ISpan.StockPortfolio.App
{
	public partial class FormSignUp : Form
	{
		private static readonly UserService _userService = new UserService();
		public FormSignUp()
		{
			InitializeComponent();
		}

		private void textBoxEmail_Validating(object sender, CancelEventArgs e)
		{
			int minimumPasswordLength = 6;

			string errorMsg;
			if (!ValidatorHelper.ValidEmailAddress(textBoxEmail.Text, out errorMsg))
			{
				// Cancel the event and select the text to be corrected by the user.
				e.Cancel = true;
				textBoxEmail.Select(0, textBoxEmail.Text.Length);

				// Set the ErrorProvider error with the text to display. 
				this.errorProvider1.SetError(textBoxEmail, errorMsg);
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

		private void textBoxEmail_Validated(object sender, EventArgs e)
		{
			errorProvider1.SetError(textBoxEmail, "");
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

		private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
			{
				MessageBox.Show("Email 或 密碼格式錯誤!");
				return;
			}

			if (_userService.GetLoginUser(textBoxEmail.Text) != null)
			{
				MessageBox.Show("您已用此Email註冊過!");
				return;
			}

			UserSignUpViewModel userSignUpViewModel = new UserSignUpViewModel()
			{
				Email = textBoxEmail.Text,
				Password = BC.HashPassword(textBoxPassword.Text)
			};


			var mapper = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>()).CreateMapper();
			var userSignUpDto = mapper.Map<UserSignUpDto>(userSignUpViewModel);
			_userService.Create(userSignUpDto);


			DialogResult = DialogResult.OK;
		}
	}
}
