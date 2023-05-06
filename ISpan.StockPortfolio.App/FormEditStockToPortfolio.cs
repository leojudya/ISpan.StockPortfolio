using AutoMapper;
using ISpan.StockPortfolio.Common;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
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
	public partial class FormEditStockToPortfolio : Form
	{
		private PortfolioDetailViewModel _vm;
		private static readonly PortfolioService _service = new PortfolioService();
		public FormEditStockToPortfolio(PortfolioDetailViewModel vm)
		{
			InitializeComponent();
			_vm = vm;
		}

		private void FormEditStockToPortfolio_Load(object sender, EventArgs e)
		{
			var vm = _vm;
			labelSymbol.Text = vm.Symbol + " - " + vm.Name;
			labelPurchaseDate.Text = vm.PurchaseDate == null ? string.Empty : "買進日: " + ((DateTime)vm.PurchaseDate).ToShortDateString();
			maskedTextBoxPrice.Text = vm.Price.ToString();
			maskedTextBoxQuantity.Text = vm.Quantity.ToString();

		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			var portfolioId = _vm.Id;
			var confirmationOfDelete = MessageBox.Show("確定要刪除嗎", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirmationOfDelete == DialogResult.No) return;

			var affectedRows = _service.Delete(portfolioId);
			if (affectedRows > 0)
			{
				MessageBox.Show("刪除成功!");
			}
			else
			{
				MessageBox.Show("刪除失敗!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			this.Owner.Close();
			DialogResult = DialogResult.OK;
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (panelBuyIn.Visible && !ValidateChildren())
			{
				MessageBox.Show("更新失敗, 請查看錯誤!");
				return;
			}

			var isBought = checkBoxCalculateProfit.Checked;

			var portfolioEditVM = new PortfolioEditViewModel()
			{
				Id = _vm.Id,
				Quantity = checkBoxCalculateProfit.Checked ? int.Parse(maskedTextBoxQuantity.Text) : (int?)null,
				Price = checkBoxCalculateProfit.Checked ? decimal.Parse(maskedTextBoxPrice.Text) : (decimal?)null,
				PurchaseDate = checkBoxCalculateProfit.Checked ? dateTimePickerPurchase.Value : (DateTime?)null,
			};

			var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
			var mapper = mapperConfiguration.CreateMapper();

			var dto = mapper.Map<PortfolioEditDto>(portfolioEditVM);
			var affectedRows = _service.Update(dto);

			if (affectedRows > 0)
			{
				MessageBox.Show("更新成功!");
			}
			else
			{
				MessageBox.Show("更新失敗!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.Owner.Close();
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
