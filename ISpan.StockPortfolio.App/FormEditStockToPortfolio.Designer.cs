namespace ISpan.StockPortfolio.App
{
	partial class FormEditStockToPortfolio
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
			this.panelBuyIn = new System.Windows.Forms.Panel();
			this.maskedTextBoxQuantity = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
			this.dateTimePickerPurchase = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxCalculateProfit = new System.Windows.Forms.CheckBox();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.labelSymbol = new System.Windows.Forms.Label();
			this.labelPurchaseDate = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panelBuyIn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelBuyIn
			// 
			this.panelBuyIn.Controls.Add(this.maskedTextBoxQuantity);
			this.panelBuyIn.Controls.Add(this.maskedTextBoxPrice);
			this.panelBuyIn.Controls.Add(this.dateTimePickerPurchase);
			this.panelBuyIn.Controls.Add(this.label4);
			this.panelBuyIn.Controls.Add(this.label3);
			this.panelBuyIn.Controls.Add(this.label2);
			this.panelBuyIn.Location = new System.Drawing.Point(0, 134);
			this.panelBuyIn.Name = "panelBuyIn";
			this.panelBuyIn.Size = new System.Drawing.Size(361, 220);
			this.panelBuyIn.TabIndex = 11;
			// 
			// maskedTextBoxQuantity
			// 
			this.maskedTextBoxQuantity.Location = new System.Drawing.Point(12, 111);
			this.maskedTextBoxQuantity.Name = "maskedTextBoxQuantity";
			this.maskedTextBoxQuantity.Size = new System.Drawing.Size(332, 39);
			this.maskedTextBoxQuantity.TabIndex = 1;
			this.maskedTextBoxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxQuantity_Validating);
			this.maskedTextBoxQuantity.Validated += new System.EventHandler(this.maskedTextBoxQuantity_Validated);
			// 
			// maskedTextBoxPrice
			// 
			this.maskedTextBoxPrice.Location = new System.Drawing.Point(12, 40);
			this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
			this.maskedTextBoxPrice.Size = new System.Drawing.Size(332, 39);
			this.maskedTextBoxPrice.TabIndex = 0;
			this.maskedTextBoxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxPrice_Validating);
			this.maskedTextBoxPrice.Validated += new System.EventHandler(this.maskedTextBoxPrice_Validated);
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 30);
			this.label4.TabIndex = 0;
			this.label4.Text = "Purchase Date";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "Price";
			// 
			// checkBoxCalculateProfit
			// 
			this.checkBoxCalculateProfit.AutoSize = true;
			this.checkBoxCalculateProfit.Checked = true;
			this.checkBoxCalculateProfit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCalculateProfit.Location = new System.Drawing.Point(12, 97);
			this.checkBoxCalculateProfit.Name = "checkBoxCalculateProfit";
			this.checkBoxCalculateProfit.Size = new System.Drawing.Size(131, 34);
			this.checkBoxCalculateProfit.TabIndex = 0;
			this.checkBoxCalculateProfit.Text = "計算損益";
			this.checkBoxCalculateProfit.UseVisualStyleBackColor = true;
			this.checkBoxCalculateProfit.CheckedChanged += new System.EventHandler(this.checkBoxCalculateProfit_CheckedChanged);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(44, 372);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(118, 57);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "Update";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// labelSymbol
			// 
			this.labelSymbol.AutoSize = true;
			this.labelSymbol.Location = new System.Drawing.Point(82, 22);
			this.labelSymbol.Name = "labelSymbol";
			this.labelSymbol.Size = new System.Drawing.Size(81, 30);
			this.labelSymbol.TabIndex = 12;
			this.labelSymbol.Text = "label1";
			// 
			// labelPurchaseDate
			// 
			this.labelPurchaseDate.AutoSize = true;
			this.labelPurchaseDate.Location = new System.Drawing.Point(82, 60);
			this.labelPurchaseDate.Name = "labelPurchaseDate";
			this.labelPurchaseDate.Size = new System.Drawing.Size(81, 30);
			this.labelPurchaseDate.TabIndex = 14;
			this.labelPurchaseDate.Text = "label6";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(205, 372);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(118, 57);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormEditStockToPortfolio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 441);
			this.Controls.Add(this.labelPurchaseDate);
			this.Controls.Add(this.labelSymbol);
			this.Controls.Add(this.panelBuyIn);
			this.Controls.Add(this.checkBoxCalculateProfit);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FormEditStockToPortfolio";
			this.Text = "StockPortfolio - Edit";
			this.Load += new System.EventHandler(this.FormEditStockToPortfolio_Load);
			this.panelBuyIn.ResumeLayout(false);
			this.panelBuyIn.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelBuyIn;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantity;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
		private System.Windows.Forms.DateTimePicker dateTimePickerPurchase;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxCalculateProfit;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label labelSymbol;
		private System.Windows.Forms.Label labelPurchaseDate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}