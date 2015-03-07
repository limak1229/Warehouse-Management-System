namespace Warehouse_Management_System
{
    partial class LoginForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ZalogujBtn = new System.Windows.Forms.Button();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Haslolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(50, 11);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(125, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(50, 37);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(125, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // ZalogujBtn
            // 
            this.ZalogujBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZalogujBtn.Location = new System.Drawing.Point(100, 63);
            this.ZalogujBtn.Name = "ZalogujBtn";
            this.ZalogujBtn.Size = new System.Drawing.Size(75, 23);
            this.ZalogujBtn.TabIndex = 2;
            this.ZalogujBtn.Text = "Zaloguj";
            this.ZalogujBtn.UseVisualStyleBackColor = true;
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Location = new System.Drawing.Point(9, 14);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(33, 13);
            this.Loginlabel.TabIndex = 3;
            this.Loginlabel.Text = "Login";
            // 
            // Haslolabel
            // 
            this.Haslolabel.AutoSize = true;
            this.Haslolabel.Location = new System.Drawing.Point(9, 40);
            this.Haslolabel.Name = "Haslolabel";
            this.Haslolabel.Size = new System.Drawing.Size(36, 13);
            this.Haslolabel.TabIndex = 4;
            this.Haslolabel.Text = "Hasło";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(186, 96);
            this.Controls.Add(this.Haslolabel);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.ZalogujBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button ZalogujBtn;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label Haslolabel;
    }
}