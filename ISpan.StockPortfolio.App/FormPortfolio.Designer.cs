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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.linkLabelAdd = new System.Windows.Forms.LinkLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// linkLabelAdd
			// 
			this.linkLabelAdd.AutoSize = true;
			this.linkLabelAdd.Location = new System.Drawing.Point(11, 20);
			this.linkLabelAdd.Name = "linkLabelAdd";
			this.linkLabelAdd.Size = new System.Drawing.Size(100, 22);
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
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(15, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1327, 610);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(1051, 12);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(290, 29);
			this.textBoxSearch.TabIndex = 2;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(955, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search";
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// FormPortfolio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1353, 678);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.linkLabelAdd);
			this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FormPortfolio";
			this.Text = "StockPortfolio";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPortfolio_FormClosing);
			this.Load += new System.EventHandler(this.FormPortfolio_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkLabelAdd;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
	}
}