namespace Тестовое_окно
{
    partial class LoginForm
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
            this.InputLoginForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginString = new System.Windows.Forms.TextBox();
            this.PasswordString = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLoginForm
            // 
            this.InputLoginForm.Location = new System.Drawing.Point(13, 129);
            this.InputLoginForm.Name = "InputLoginForm";
            this.InputLoginForm.Size = new System.Drawing.Size(94, 29);
            this.InputLoginForm.TabIndex = 0;
            this.InputLoginForm.Text = "Input";
            this.InputLoginForm.UseVisualStyleBackColor = true;
            this.InputLoginForm.Click += new System.EventHandler(this.InputLoginForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // LoginString
            // 
            this.LoginString.Location = new System.Drawing.Point(11, 33);
            this.LoginString.Name = "LoginString";
            this.LoginString.Size = new System.Drawing.Size(219, 27);
            this.LoginString.TabIndex = 5;
            // 
            // PasswordString
            // 
            this.PasswordString.Location = new System.Drawing.Point(13, 90);
            this.PasswordString.Name = "PasswordString";
            this.PasswordString.Size = new System.Drawing.Size(217, 27);
            this.PasswordString.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(136, 129);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 29);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 170);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PasswordString);
            this.Controls.Add(this.LoginString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputLoginForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login Windows";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button InputLoginForm;
        private Label label1;
        private Label label2;
        private TextBox LoginString;
        private TextBox PasswordString;
        private Button ExitButton;
    }
}