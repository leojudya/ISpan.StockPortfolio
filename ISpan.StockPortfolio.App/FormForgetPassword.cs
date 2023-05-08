using ISpan.StockPortfolio.DataAccessLayer;
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
	public partial class FormForgetPassword : Form
	{
		private readonly string _email;
		private readonly UserService _userService;
		public FormForgetPassword(string email)
		{
			InitializeComponent();
			_email = email;
			_userService = new UserService();
		}

		private void buttonCreateCode_Click(object sender, EventArgs e)
		{
			_userService.CreateForgetPassword(_email);
		}

		private void buttonVerify_Click(object sender, EventArgs e)
		{
			var isValidCode = _userService.VerifyForgetPassword(_email, textBoxCode.Text);

			if (isValidCode)
			{
				MessageBox.Show("OK");
			}
			else
			{
				MessageBox.Show("失敗");
			}
		}
	}
}
