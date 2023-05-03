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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePickerPurchase = new System.Windows.Forms.DateTimePicker();
			this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
			this.comboBoxStocks = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select Stock";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Price";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Quantity";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 225);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Purchase Date";
			// 
			// dateTimePickerPurchase
			// 
			this.dateTimePickerPurchase.Location = new System.Drawing.Point(30, 252);
			this.dateTimePickerPurchase.MaxDate = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
			this.dateTimePickerPurchase.Name = "dateTimePickerPurchase";
			this.dateTimePickerPurchase.Size = new System.Drawing.Size(332, 32);
			this.dateTimePickerPurchase.TabIndex = 2;
			this.dateTimePickerPurchase.Value = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
			// 
			// numericUpDownQuantity
			// 
			this.numericUpDownQuantity.Location = new System.Drawing.Point(30, 181);
			this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownQuantity.Name = "numericUpDownQuantity";
			this.numericUpDownQuantity.Size = new System.Drawing.Size(332, 32);
			this.numericUpDownQuantity.TabIndex = 3;
			this.numericUpDownQuantity.ThousandsSeparator = true;
			this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownPrice
			// 
			this.numericUpDownPrice.DecimalPlaces = 2;
			this.numericUpDownPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDownPrice.Location = new System.Drawing.Point(30, 111);
			this.numericUpDownPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDownPrice.Name = "numericUpDownPrice";
			this.numericUpDownPrice.Size = new System.Drawing.Size(332, 32);
			this.numericUpDownPrice.TabIndex = 3;
			this.numericUpDownPrice.ThousandsSeparator = true;
			this.numericUpDownPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			// 
			// comboBoxStocks
			// 
			this.comboBoxStocks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxStocks.FormattingEnabled = true;
			this.comboBoxStocks.Location = new System.Drawing.Point(30, 40);
			this.comboBoxStocks.Name = "comboBoxStocks";
			this.comboBoxStocks.Size = new System.Drawing.Size(332, 32);
			this.comboBoxStocks.TabIndex = 4;
			this.comboBoxStocks.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxStocks_Format);
			this.comboBoxStocks.Leave += new System.EventHandler(this.comboBoxStocks_Leave);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(128, 336);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(118, 57);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// FormAddStockToPortfolio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 441);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comboBoxStocks);
			this.Controls.Add(this.numericUpDownPrice);
			this.Controls.Add(this.numericUpDownQuantity);
			this.Controls.Add(this.dateTimePickerPurchase);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FormAddStockToPortfolio";
			this.Text = "FormAddStockToPortfolio";
			this.Load += new System.EventHandler(this.FormAddStockToPortfolio_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePickerPurchase;
		private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
		private System.Windows.Forms.NumericUpDown numericUpDownPrice;
		private System.Windows.Forms.ComboBox comboBoxStocks;
		private System.Windows.Forms.Button buttonAdd;
	}
}