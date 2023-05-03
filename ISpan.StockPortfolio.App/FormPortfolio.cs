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
	public partial class FormPortfolio : Form
	{
		public FormPortfolio()
		{
			InitializeComponent();
		}

		private void linkLabelAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new FormAddStockToPortfolio();
			frm.ShowDialog();
		}
	}
}
