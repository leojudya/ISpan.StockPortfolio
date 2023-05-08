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
			this.buttonCreateCode.Location = new System.Drawing.Point(112, 29);
			this.buttonCreateCode.Name = "buttonCreateCode";
			this.buttonCreateCode.Size = new System.Drawing.Size(97, 33);
			this.buttonCreateCode.TabIndex = 0;
			this.buttonCreateCode.Text = "傳送驗證碼";
			this.buttonCreateCode.UseVisualStyleBackColor = true;
			this.buttonCreateCode.Click += new System.EventHandler(this.buttonCreateCode_Click);
			// 
			// textBoxCode
			// 
			this.textBoxCode.Location = new System.Drawing.Point(101, 157);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(186, 22);
			this.textBoxCode.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "驗證碼";
			// 
			// buttonVerify
			// 
			this.buttonVerify.Location = new System.Drawing.Point(134, 253);
			this.buttonVerify.Name = "buttonVerify";
			this.buttonVerify.Size = new System.Drawing.Size(75, 23);
			this.buttonVerify.TabIndex = 3;
			this.buttonVerify.Text = "驗證";
			this.buttonVerify.UseVisualStyleBackColor = true;
			this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(101, 110);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(186, 22);
			this.textBoxEmail.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "Email";
			// 
			// FormForgetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 317);
			this.Controls.Add(this.buttonVerify);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.buttonCreateCode);
			this.Name = "FormForgetPassword";
			this.Text = "FormForgetPassword";
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