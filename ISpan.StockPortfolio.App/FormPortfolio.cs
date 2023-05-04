using ISpan.StockPortfolio.DataAccessLayer.Models;
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
	public partial class FormPortfolio : Form
	{
		private int _userId;
		private static readonly PortfolioService _portfolioService = new PortfolioService();
		public FormPortfolio(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		private void linkLabelAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new FormAddStockToPortfolio(_userId);
			frm.ShowDialog();
		}

		private void FormPortfolio_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Task.Run(() => _portfolioService.GetPortfolio(_userId)).Result.ToList();

			dataGridView1.Columns["UpAndDown"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["UpAndDown"].DefaultCellStyle.ForeColor = Color.Red;
			dataGridView1.Columns["UpAndDownPercentage"].DefaultCellStyle.Format = "P2";
			dataGridView1.Columns["UpAndDown"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["OpeningPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["BidPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["MarketPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["AskPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["HighestPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["LowestPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["ClosingPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["LastUpdated"].DefaultCellStyle.Format = "yyyy/MM/dd hh:mm:ss";
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.dataGridView1.Columns[e.ColumnIndex].Name == "UpAndDownPercentage" || this.dataGridView1.Columns[e.ColumnIndex].Name == "UpAndDown")
			{
				if ((decimal)e.Value > 0m) e.CellStyle.ForeColor = Color.Red;
				if ((decimal)e.Value < 0m) e.CellStyle.ForeColor = Color.Green;
			}
		}
	}
}
