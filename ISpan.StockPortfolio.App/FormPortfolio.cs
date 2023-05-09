using AutoMapper;
using ISpan.StockPortfolio.Common;
using ISpan.StockPortfolio.DataAccessLayer.Models;
using ISpan.StockPortfolio.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.StockPortfolio.App
{
	public partial class FormPortfolio : Form, IGrid
	{
		private int _userId;
		private static readonly PortfolioService _portfolioService = new PortfolioService();
		private List<PortfolioDetailViewModel> _portfolios;
		private static MapperConfiguration _mapperConfiguration;
		private static IMapper _mapper;
		public FormPortfolio(int userId)
		{
			InitializeComponent();
			_userId = userId;
			_mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
			_mapper = _mapperConfiguration.CreateMapper();
		}

		private void linkLabelAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new FormAddStockToPortfolio(_userId);
			frm.Owner = this;
			frm.ShowDialog();
		}

		public void Display()
		{
			_portfolios = Task.Run(() => _portfolioService.GetPortfolio(_userId)).Result.ToList();
			var portfolios = _mapper.Map<List<PortfolioViewModel>>(_portfolios);
			dataGridView1.DataSource = GroupPortfolioParse(portfolios).ToList();
			SearchBySymbolOrName();
		}

		private void FormPortfolio_Load(object sender, EventArgs e)
		{
			timer1.Start();
			Display();

			dataGridView1.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridView1.Columns["UpAndDown"].DefaultCellStyle.Format = "+0.00;-0.00;0";
			dataGridView1.Columns["UpAndDownPercentage"].DefaultCellStyle.Format = "+0.00%;-0.00%;0%";
			dataGridView1.Columns["OpeningPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["BidPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["MarketPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["AskPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["HighestPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["LowestPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["ClosingPrice"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["Profit"].DefaultCellStyle.Format = "+#,#;-#,#;0";
			dataGridView1.Columns["LastUpdated"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.dataGridView1.Columns[e.ColumnIndex].Name == "UpAndDownPercentage" || this.dataGridView1.Columns[e.ColumnIndex].Name == "UpAndDown")
			{
				if ((decimal)e.Value > 0m) e.CellStyle.ForeColor = Color.Red;
				if ((decimal)e.Value < 0m) e.CellStyle.ForeColor = Color.Green;
			}

			if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Profit")
			{
				if (e.Value == null) return;
				if ((int)e.Value > 0m) e.CellStyle.ForeColor = Color.Red;
				if ((int)e.Value < 0m) e.CellStyle.ForeColor = Color.Green;
			}

		}

		private IEnumerable<PortfolioViewModel> GroupPortfolioParse(IEnumerable<PortfolioViewModel> portfolios)
		{
			var query = (from p in portfolios
						 group p by new
						 {
							 p.Name,
							 p.Symbol,
							 p.UpAndDown,
							 p.UpAndDownPercentage,
							 p.OpeningPrice,
							 p.BidPrice,
							 p.MarketPrice,
							 p.AskPrice,
							 p.HighestPrice,
							 p.LowestPrice,
							 p.ClosingPrice,
							 p.TradingVolume,
							 p.LastUpdated
						 }
						 into g
						 select new PortfolioViewModel
						 {
							 Name = g.Key.Name,
							 Symbol = g.Key.Symbol,
							 OpeningPrice = g.Key.OpeningPrice,
							 BidPrice = g.Key.BidPrice,
							 MarketPrice = g.Key.MarketPrice,
							 AskPrice = g.Key.AskPrice,
							 HighestPrice = g.Key.HighestPrice,
							 LowestPrice = g.Key.LowestPrice,
							 ClosingPrice = g.Key.ClosingPrice,
							 TradingVolume = g.Key.TradingVolume,
							 LastUpdated = g.Key.LastUpdated,
							 Profit = g.Sum(p => p.Profit)
						 });

			return query;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var frm = new FormPortfolioStockDetail(_portfolios.Where(p => p.Symbol == (string)dataGridView1.Rows[e.RowIndex].Cells["Symbol"].Value).ToList());
				frm.Owner = this;
				frm.ShowDialog();
			}


		}

		private void SearchBySymbolOrName()
		{
			var portfolios = GroupPortfolioParse(_mapper.Map<List<PortfolioViewModel>>(_portfolios)).ToList();

			if (textBoxSearch.Text == string.Empty)
			{
				dataGridView1.DataSource = portfolios;
			}

			dataGridView1.DataSource = portfolios.Where(p => p.Name.Contains(textBoxSearch.Text) || p.Symbol.Contains(textBoxSearch.Text)).ToList();

		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			SearchBySymbolOrName();
		}

		private void FormPortfolio_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Display();
		}
	}

}
