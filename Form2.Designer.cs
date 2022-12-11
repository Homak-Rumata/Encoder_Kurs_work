namespace Тестовое_окно
{
    partial class MainForm
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
            ParentForm.Close();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.SaveInDB = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ToCrypt = new System.Windows.Forms.Button();
            this.ToUnCrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(725, 447);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(751, 292);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(164, 29);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(751, 327);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(164, 29);
            this.SaveAsButton.TabIndex = 2;
            this.SaveAsButton.Text = "Save As";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(751, 362);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(164, 29);
            this.Open.TabIndex = 3;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            // 
            // SaveInDB
            // 
            this.SaveInDB.Location = new System.Drawing.Point(751, 397);
            this.SaveInDB.Name = "SaveInDB";
            this.SaveInDB.Size = new System.Drawing.Size(164, 29);
            this.SaveInDB.TabIndex = 4;
            this.SaveInDB.Text = "Save in DB";
            this.SaveInDB.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(751, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ToCrypt
            // 
            this.ToCrypt.Location = new System.Drawing.Point(751, 12);
            this.ToCrypt.Name = "ToCrypt";
            this.ToCrypt.Size = new System.Drawing.Size(164, 29);
            this.ToCrypt.TabIndex = 6;
            this.ToCrypt.Text = "Codding";
            this.ToCrypt.UseVisualStyleBackColor = true;
            // 
            // ToUnCrypt
            // 
            this.ToUnCrypt.Location = new System.Drawing.Point(751, 47);
            this.ToUnCrypt.Name = "ToUnCrypt";
            this.ToUnCrypt.Size = new System.Drawing.Size(164, 29);
            this.ToUnCrypt.TabIndex = 7;
            this.ToUnCrypt.Text = "Uncodding";
            this.ToUnCrypt.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 473);
            this.Controls.Add(this.ToUnCrypt);
            this.Controls.Add(this.ToCrypt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SaveInDB);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainForm";
            this.Text = "Main Windows";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button SaveButton;
        private Button SaveAsButton;
        private Button Open;
        private Button SaveInDB;
        private Button button5;
        private Button ToCrypt;
        private Button ToUnCrypt;
    }
}