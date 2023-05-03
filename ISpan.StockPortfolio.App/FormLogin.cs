using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using ISpan.StockPortfolio.DataAccessLayer;

namespace ISpan.StockPortfolio.App
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

        }

		private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new FormSignUp();
			frm.ShowDialog();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			var frm = new FormPortfolio();
			frm.ShowDialog();
		}
	}
}
