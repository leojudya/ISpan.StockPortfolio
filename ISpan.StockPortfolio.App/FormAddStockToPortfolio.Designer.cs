using System;

namespace ISpan.StockPortfolio.App
{
	partial class FormAddStockToPortfolio
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePickerPurchase = new System.Windows.Forms.DateTimePicker();
			this.comboBoxStocks = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBoxQuantity = new System.Windows.Forms.MaskedTextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.checkBoxCalculateProfit = new System.Windows.Forms.CheckBox();
			this.panelBuyIn = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panelBuyIn.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select Stock";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "Price";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 30);
			this.label3.TabIndex = 0;
			this.label3.Text = "Quantity";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 30);
			this.label4.TabIndex = 0;
			this.label4.Text = "Purchase Date";
			// 
			// dateTimePickerPurchase
			// 
			this.dateTimePickerPurchase.Checked = false;
			this.dateTimePickerPurchase.Location = new System.Drawing.Point(12, 173);
			this.dateTimePickerPurchase.MaxDate = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
			this.dateTimePickerPurchase.Name = "dateTimePickerPurchase";
			this.dateTimePickerPurchase.Size = new System.Drawing.Size(332, 39);
			this.dateTimePickerPurchase.TabIndex = 2;
			this.dateTimePickerPurchase.Value = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
			// 
			// comboBoxStocks
			// 
			this.comboBoxStocks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxStocks.FormattingEnabled = true;
			this.comboBoxStocks.Location = new System.Drawing.Point(30, 40);
			this.comboBoxStocks.Name = "comboBoxStocks";
			this.comboBoxStocks.Size = new System.Drawing.Size(332, 37);
			this.comboBoxStocks.TabIndex = 4;
			this.comboBoxStocks.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxStocks_Format);
			this.comboBoxStocks.Leave += new System.EventHandler(this.comboBoxStocks_Leave);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(128, 347);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(118, 57);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// maskedTextBoxPrice
			// 
			this.maskedTextBoxPrice.Location = new System.Drawing.Point(12, 40);
			this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
			this.maskedTextBoxPrice.Size = new System.Drawing.Size(332, 39);
			this.maskedTextBoxPrice.TabIndex = 6;
			this.maskedTextBoxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxPrice_Validating);
			this.maskedTextBoxPrice.Validated += new System.EventHandler(this.maskedTextBoxPrice_Validated);
			// 
			// maskedTextBoxQuantity
			// 
			this.maskedTextBoxQuantity.Location = new System.Drawing.Point(12, 111);
			this.maskedTextBoxQuantity.Name = "maskedTextBoxQuantity";
			this.maskedTextBoxQuantity.Size = new System.Drawing.Size(332, 39);
			this.maskedTextBoxQuantity.TabIndex = 6;
			this.maskedTextBoxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxQuantity_Validating);
			this.maskedTextBoxQuantity.Validated += new System.EventHandler(this.maskedTextBoxQuantity_Validated);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// checkBoxCalculateProfit
			// 
			this.checkBoxCalculateProfit.AutoSize = true;
			this.checkBoxCalculateProfit.Checked = true;
			this.checkBoxCalculateProfit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCalculateProfit.Location = new System.Drawing.Point(30, 90);
			this.checkBoxCalculateProfit.Name = "checkBoxCalculateProfit";
			this.checkBoxCalculateProfit.Size = new System.Drawing.Size(131, 34);
			this.checkBoxCalculateProfit.TabIndex = 7;
			this.checkBoxCalculateProfit.Text = "計算損益";
			this.checkBoxCalculateProfit.UseVisualStyleBackColor = true;
			this.checkBoxCalculateProfit.CheckedChanged += new System.EventHandler(this.checkBoxCalculateProfit_CheckedChanged);
			// 
			// panelBuyIn
			// 
			this.panelBuyIn.Controls.Add(this.maskedTextBoxQuantity);
			this.panelBuyIn.Controls.Add(this.maskedTextBoxPrice);
			this.panelBuyIn.Controls.Add(this.dateTimePickerPurchase);
			this.panelBuyIn.Controls.Add(this.label4);
			this.panelBuyIn.Controls.Add(this.label3);
			this.panelBuyIn.Controls.Add(this.label2);
			this.panelBuyIn.Location = new System.Drawing.Point(18, 127);
			this.panelBuyIn.Name = "panelBuyIn";
			this.panelBuyIn.Size = new System.Drawing.Size(361, 220);
			this.panelBuyIn.TabIndex = 8;
			// 
			// FormAddStockToPortfolio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(384, 441);
			this.Controls.Add(this.panelBuyIn);
			this.Controls.Add(this.checkBoxCalculateProfit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comboBoxStocks);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FormAddStockToPortfolio";
			this.Text = " ";
			this.Load += new System.EventHandler(this.FormAddStockToPortfolio_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panelBuyIn.ResumeLayout(false);
			this.panelBuyIn.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePickerPurchase;
		private System.Windows.Forms.ComboBox comboBoxStocks;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantity;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panelBuyIn;
		private System.Windows.Forms.CheckBox checkBoxCalculateProfit;
	}
}