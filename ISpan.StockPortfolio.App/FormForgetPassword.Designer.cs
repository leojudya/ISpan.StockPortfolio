namespace ISpan.StockPortfolio.App
{
	partial class FormForgetPassword
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
			this.buttonCreateCode = new System.Windows.Forms.Button();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonVerify = new System.Windows.Forms.Button();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonCreateCode
			// 
			this.buttonCreateCode.Location = new System.Drawing.Point(149, 36);
			this.buttonCreateCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonCreateCode.Name = "buttonCreateCode";
			this.buttonCreateCode.Size = new System.Drawing.Size(129, 41);
			this.buttonCreateCode.TabIndex = 0;
			this.buttonCreateCode.Text = "傳送驗證碼";
			this.buttonCreateCode.UseVisualStyleBackColor = true;
			this.buttonCreateCode.Click += new System.EventHandler(this.buttonCreateCode_Click);
			// 
			// textBoxCode
			// 
			this.textBoxCode.Location = new System.Drawing.Point(135, 196);
			this.textBoxCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(247, 25);
			this.textBoxCode.TabIndex = 1;
			this.textBoxCode.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 200);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "驗證碼";
			this.label1.Visible = false;
			// 
			// buttonVerify
			// 
			this.buttonVerify.Location = new System.Drawing.Point(179, 316);
			this.buttonVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonVerify.Name = "buttonVerify";
			this.buttonVerify.Size = new System.Drawing.Size(100, 29);
			this.buttonVerify.TabIndex = 3;
			this.buttonVerify.Text = "驗證";
			this.buttonVerify.UseVisualStyleBackColor = true;
			this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(135, 138);
			this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(247, 25);
			this.textBoxEmail.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 141);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Email";
			// 
			// FormForgetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 396);
			this.Controls.Add(this.buttonVerify);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.buttonCreateCode);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormForgetPassword";
			this.Text = "StockPortfolio - ForgetPassword";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCreateCode;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonVerify;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label label2;
	}
}