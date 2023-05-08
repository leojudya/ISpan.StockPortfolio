namespace ISpan.StockPortfolio.App
{
	partial class FormEditPassword
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
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.buttonSubmit.Location = new System.Drawing.Point(151, 232);
			this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(128, 52);
			this.buttonSubmit.TabIndex = 11;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// textBoxConfirmPassword
			// 
			this.textBoxConfirmPassword.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.textBoxConfirmPassword.Location = new System.Drawing.Point(39, 161);
			this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
			this.textBoxConfirmPassword.PasswordChar = '*';
			this.textBoxConfirmPassword.Size = new System.Drawing.Size(355, 39);
			this.textBoxConfirmPassword.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label3.Location = new System.Drawing.Point(34, 124);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(217, 30);
			this.label3.TabIndex = 13;
			this.label3.Text = "Confirm Password";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.textBoxPassword.Location = new System.Drawing.Point(34, 72);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(360, 39);
			this.textBoxPassword.TabIndex = 9;
			this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
			this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F);
			this.label2.Location = new System.Drawing.Point(38, 35);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 30);
			this.label2.TabIndex = 12;
			this.label2.Text = "Password";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormEditPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(454, 326);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.textBoxConfirmPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label2);
			this.Name = "FormEditPassword";
			this.Text = "StockPortfolio - Reset Password";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditPassword_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.TextBox textBoxConfirmPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}