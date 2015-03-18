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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.loginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ZalogujButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Login:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Hasło:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(73, 64);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(146, 23);
            this.loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(73, 93);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(146, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // ZalogujButton
            // 
            this.ZalogujButton.Location = new System.Drawing.Point(144, 122);
            this.ZalogujButton.Name = "ZalogujButton";
            this.ZalogujButton.Size = new System.Drawing.Size(75, 23);
            this.ZalogujButton.TabIndex = 4;
            this.ZalogujButton.Text = "Zaloguj";
            this.ZalogujButton.Click += new System.EventHandler(this.ZalogujButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(242, 168);
            this.Controls.Add(this.ZalogujButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Logowanie";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox loginTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroButton ZalogujButton;

    }
}