using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using ISpan.StockPortfolio.Services;

namespace ISpan.StockPortfolio.App
{
	public partial class FormAddStockToPortfolio : Form
	{
		private static StockService _stockService = new StockService();
		private List<StockDto> _stocks = new List<StockDto>();
		public FormAddStockToPortfolio()
		{
			InitializeComponent();
		}

		private void FormAddStockToPortfolio_Load(object sender, EventArgs e)
		{
			_stocks = _stockService.GetAllStock().ToList();
			comboBoxStocks.DataSource = _stocks;
			comboBoxStocks.ValueMember = "Name";
			comboBoxStocks.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		private void BindStocksComboBox()
		{
			
		}

		private void comboBoxStocks_Leave(object sender, EventArgs e)
		{
			if (!StockExists(comboBoxStocks.Text))
			{
				comboBoxStocks.SelectedIndex = 0;
				MessageBox.Show("目前尚無提供此股票查詢!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool StockExists(string name)
		{
			return _stocks.Where(s => s.Name == name).Any();
		}

		private void comboBoxStocks_Format(object sender, ListControlConvertEventArgs e)
		{
			string symbol = ((StockDto)e.ListItem).StockSymbol;
			string name = ((StockDto)e.ListItem).Name;
			e.Value = symbol + " - " + name;
		}
	}
}
