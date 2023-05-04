namespace ISpan.StockPortfolio.App
{
	partial class FormPortfolio
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
			this.linkLabelAdd = new System.Windows.Forms.LinkLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// linkLabelAdd
			// 
			this.linkLabelAdd.AutoSize = true;
			this.linkLabelAdd.Location = new System.Drawing.Point(12, 21);
			this.linkLabelAdd.Name = "linkLabelAdd";
			this.linkLabelAdd.Size = new System.Drawing.Size(98, 24);
			this.linkLabelAdd.TabIndex = 0;
			this.linkLabelAdd.TabStop = true;
			this.linkLabelAdd.Text = "Add new..";
			this.linkLabelAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAdd_LinkClicked);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(16, 60);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1231, 515);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			// 
			// FormPortfolio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1259, 587);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.linkLabelAdd);
			this.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FormPortfolio";
			this.Text = "StockPortfolio";
			this.Load += new System.EventHandler(this.FormPortfolio_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkLabelAdd;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}