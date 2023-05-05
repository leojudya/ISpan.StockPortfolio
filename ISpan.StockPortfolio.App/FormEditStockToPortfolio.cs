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
	public partial class FormEditStockToPortfolio : Form
	{
		private PortfolioDetailViewModel _vm;
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
	}
}
