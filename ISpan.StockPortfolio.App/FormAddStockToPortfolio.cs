using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using ISpan.StockPortfolio.DataAccessLayer.Models;
using ISpan.StockPortfolio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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

			dateTimePickerPurchase.MaxDate = DateTime.Today;
			dateTimePickerPurchase.Value = DateTime.Today;
			comboBoxVipStock.DataSource = _stocks;
			comboBoxVipStock.ValueMember = "Name";
			comboBoxVipStock.AutoCompleteSource = AutoCompleteSource.ListItems;

		}

		private void comboBoxVipStock_Leave(object sender, EventArgs e)
		{
			if (!StockExists(comboBoxVipStock.SelectedItem))
			{
				comboBoxVipStock.SelectedIndex = 0;
				MessageBox.Show("目前尚無提供此股票查詢!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void comboBoxVipStock_Format(object sender, ListControlConvertEventArgs e)
		{
			string symbol = ((StockDto)e.ListItem).StockSymbol;
			string name = ((StockDto)e.ListItem).Name;
			e.Value = symbol + " - " + name;
		}

		private bool StockExists(object obj)
		{
			return _stocks.Where(s => (StockDto)obj == s).Any();
		}


		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (panelBuyIn.Visible && !ValidateChildren())
			{
				MessageBox.Show("新增失敗, 請查看錯誤!");
				return;
			}

			StockDto selectedStock = (StockDto)comboBoxVipStock.SelectedItem;

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

			IGrid owner = this.Owner as IGrid;
			if (owner != null)
			{
				owner.Display();
			}

			DialogResult = DialogResult.OK;
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
