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
		private readonly UserService _userService;
		public FormForgetPassword()
		{
			InitializeComponent();
			_userService = new UserService();
		}

		private void buttonCreateCode_Click(object sender, EventArgs e)
		{
			_userService.CreateForgetPassword(textBoxEmail.Text);
			label1.Visible = true;
			textBoxCode.Visible = true;
		}

		private void buttonVerify_Click(object sender, EventArgs e)
		{
			var isValidCode = _userService.VerifyForgetPassword(textBoxEmail.Text, textBoxCode.Text);

			if (!isValidCode)
			{
				MessageBox.Show("驗證碼錯誤或過期, 請重發驗證碼, 或是確認Email有無註冊!");
				return;
			}
			
			_userService.DeleteForgetPassword(textBoxEmail.Text);

			var frm = new FormEditPassword(textBoxEmail.Text);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
