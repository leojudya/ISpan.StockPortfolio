namespace ISpan.StockPortfolio.App
{
	partial class FormLogin
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.buttonLogin.Location = new System.Drawing.Point(129, 209);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(108, 46);
			this.buttonLogin.TabIndex = 0;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label1.Location = new System.Drawing.Point(32, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label2.Location = new System.Drawing.Point(32, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.textBoxEmail.Location = new System.Drawing.Point(148, 46);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(200, 32);
			this.textBoxEmail.TabIndex = 3;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.textBoxPassword.Location = new System.Drawing.Point(148, 116);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(200, 32);
			this.textBoxPassword.TabIndex = 3;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// linkLabelSignUp
			// 
			this.linkLabelSignUp.AutoSize = true;
			this.linkLabelSignUp.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.linkLabelSignUp.Location = new System.Drawing.Point(82, 296);
			this.linkLabelSignUp.Name = "linkLabelSignUp";
			this.linkLabelSignUp.Size = new System.Drawing.Size(209, 24);
			this.linkLabelSignUp.TabIndex = 4;
			this.linkLabelSignUp.TabStop = true;
			this.linkLabelSignUp.Text = "還沒有帳號嗎, 按此註冊";
			this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 360);
			this.Controls.Add(this.linkLabelSignUp);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLogin);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormLogin";
			this.Text = "StockPortfolio - Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.LinkLabel linkLabelSignUp;
	}
}

