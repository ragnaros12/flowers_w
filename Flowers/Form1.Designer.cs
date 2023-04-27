namespace Flowers
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			LoginButton = new Button();
			Login = new TextBox();
			Password = new TextBox();
			Errors = new Label();
			SuspendLayout();
			// 
			// LoginButton
			// 
			LoginButton.Location = new Point(181, 343);
			LoginButton.Name = "LoginButton";
			LoginButton.Size = new Size(286, 23);
			LoginButton.TabIndex = 0;
			LoginButton.Text = "button1";
			LoginButton.UseVisualStyleBackColor = true;
			LoginButton.Click += LoginButton_Click;
			// 
			// Login
			// 
			Login.Location = new Point(181, 64);
			Login.Name = "Login";
			Login.Size = new Size(266, 23);
			Login.TabIndex = 1;
			// 
			// Password
			// 
			Password.Location = new Point(181, 109);
			Password.Name = "Password";
			Password.Size = new Size(266, 23);
			Password.TabIndex = 2;
			// 
			// Errors
			// 
			Errors.AutoSize = true;
			Errors.Location = new Point(181, 214);
			Errors.Name = "Errors";
			Errors.Size = new Size(38, 15);
			Errors.TabIndex = 3;
			Errors.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Errors);
			Controls.Add(Password);
			Controls.Add(Login);
			Controls.Add(LoginButton);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button LoginButton;
		private TextBox Login;
		private TextBox Password;
		private Label Errors;
	}
}