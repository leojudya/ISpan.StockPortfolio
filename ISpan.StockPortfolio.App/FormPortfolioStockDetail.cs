using ISpan.StockPortfolio.DataAccessLayer.Models;
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
	public partial class FormPortfolioStockDetail : Form
	{
		List<PortfolioDetailViewModel> _portfolios;
		public FormPortfolioStockDetail(List<PortfolioDetailViewModel> portfolios)
		{
			InitializeComponent();
			_portfolios = portfolios;
		}

		private void FormPortfolioStockDetail_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _portfolios;

			dataGridView1.Columns["UpAndDown"].DefaultCellStyle.Format = "+0.00;-0.00;0";
			dataGridView1.Columns["UpAndDownPercentage"].DefaultCellStyle.Format = "+0.00%;-0.00%;0%";
			dataGridView1.Columns["OpeningPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["BidPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["MarketPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["AskPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["HighestPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["LowestPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["ClosingPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["LastUpdated"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.dataGridView1.Columns[e.ColumnIndex].Name == "UpAndDownPercentage" || this.dataGridView1.Columns[e.ColumnIndex].Name == "UpAndDown")
			{
				if ((decimal)e.Value > 0m) e.CellStyle.ForeColor = Color.Red;
				if ((decimal)e.Value < 0m) e.CellStyle.ForeColor = Color.Green;
			}

			if (this.dataGridView1.Columns[e.ColumnIndex].Name == "UpAndDown")
			{
			}

		}
	}
}
