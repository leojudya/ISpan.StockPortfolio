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
using ISpan.StockPortfolio.DataAccessLayer.Models;
using ISpan.StockPortfolio.Services;

namespace ISpan.StockPortfolio.App
{
	public partial class FormAddStockToPortfolio : Form
	{
		private static StockService _stockService = new StockService();
		private static PortfolioService _portfolioService = new PortfolioService();
		private List<StockDto> _stocks = new List<StockDto>();
		private readonly int _userId;
		public FormAddStockToPortfolio(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		private void FormAddStockToPortfolio_Load(object sender, EventArgs e)
		{
			_stocks = _stockService.GetAllStock().ToList();
			comboBoxStocks.DataSource = _stocks;
			comboBoxStocks.ValueMember = "Name";
			comboBoxStocks.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		private void comboBoxStocks_Leave(object sender, EventArgs e)
		{
			if (!StockExists(comboBoxStocks.SelectedItem))
			{
				comboBoxStocks.SelectedIndex = 0;
				MessageBox.Show("目前尚無提供此股票查詢!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool StockExists(object obj)
		{
			return _stocks.Where(s => (StockDto)obj == s).Any();
		}

		private void comboBoxStocks_Format(object sender, ListControlConvertEventArgs e)
		{
			string symbol = ((StockDto)e.ListItem).StockSymbol;
			string name = ((StockDto)e.ListItem).Name;
			e.Value = symbol + " - " + name;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (panelBuyIn.Visible && !ValidateChildren())
			{
				MessageBox.Show("新增失敗, 請查看錯誤!");
				return;
			}

			StockDto selectedStock = (StockDto)comboBoxStocks.SelectedItem;

			var portfolio = new PortfolioAddViewModel()
			{
				UserId = _userId,
				StockId = selectedStock.Id,
				Symbol = selectedStock.StockSymbol,
				Quantity = panelBuyIn.Visible ? int.Parse(maskedTextBoxQuantity.Text) : (int?)null,
				Price = panelBuyIn.Visible ? decimal.Parse(maskedTextBoxPrice.Text) : (decimal?)null,
				PurchaseDate = panelBuyIn.Visible ? dateTimePickerPurchase.Value : (DateTime?)null
			};

			_portfolioService.InsertPortfolio(portfolio);
		}

		private void checkBoxCalculateProfit_CheckedChanged(object sender, EventArgs e)
		{
			var isChecked = checkBoxCalculateProfit.Checked;

			if (isChecked)
			{
				panelBuyIn.Visible = true;
				dateTimePickerPurchase.Checked = true;
			}
			else
			{
				EmptyPanelChildren();
				panelBuyIn.Visible = false;
			}
		}

		private void EmptyPanelChildren()
		{
			maskedTextBoxPrice.Text = string.Empty;
			maskedTextBoxQuantity.Text = string.Empty;
			dateTimePickerPurchase.Checked = false;
		}

		private void maskedTextBoxPrice_Validating(object sender, CancelEventArgs e)
		{
			string errorMsg;
			if (!ValidatorHelper.ValidBuyPrice(maskedTextBoxPrice.Text, out errorMsg))
			{
				e.Cancel = true;
				maskedTextBoxPrice.Select(0, maskedTextBoxPrice.Text.Length);
				this.errorProvider1.SetError(maskedTextBoxPrice, errorMsg);
			}
		}

		private void maskedTextBoxPrice_Validated(object sender, EventArgs e)
		{
			this.errorProvider1.SetError(maskedTextBoxPrice, string.Empty);
		}

		private void maskedTextBoxQuantity_Validating(object sender, CancelEventArgs e)
		{
			string errorMsg;
			if (!ValidatorHelper.IsValidPositiveInt32(maskedTextBoxQuantity.Text, out errorMsg))
			{
				e.Cancel = true;
				maskedTextBoxQuantity.Select(0, maskedTextBoxQuantity.Text.Length);
				this.errorProvider1.SetError(maskedTextBoxQuantity, errorMsg);
			}
		}

		private void maskedTextBoxQuantity_Validated(object sender, EventArgs e)
		{
			this.errorProvider1.SetError(maskedTextBoxQuantity, string.Empty);
		}

	}
}
