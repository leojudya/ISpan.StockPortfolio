namespace ISpan.StockPortfolio.App
{
	partial class FormSignUp
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
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.textBoxPassword.Location = new System.Drawing.Point(12, 122);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(271, 32);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
			this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.textBoxEmail.Location = new System.Drawing.Point(12, 51);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(271, 32);
			this.textBoxEmail.TabIndex = 0;
			this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
			this.textBoxEmail.Validated += new System.EventHandler(this.textBoxEmail_Validated);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label2.Location = new System.Drawing.Point(15, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label1.Location = new System.Drawing.Point(15, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Email";
			// 
			// textBoxConfirmPassword
			// 
			this.textBoxConfirmPassword.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.textBoxConfirmPassword.Location = new System.Drawing.Point(16, 193);
			this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
			this.textBoxConfirmPassword.PasswordChar = '*';
			this.textBoxConfirmPassword.Size = new System.Drawing.Size(267, 32);
			this.textBoxConfirmPassword.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label3.Location = new System.Drawing.Point(12, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "Confirm Password";
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.buttonSubmit.Location = new System.Drawing.Point(100, 250);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(96, 42);
			this.buttonSubmit.TabIndex = 3;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormSignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(311, 304);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.textBoxConfirmPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormSignUp";
			this.Text = "StockPortfolio - Sign Up";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxConfirmPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}