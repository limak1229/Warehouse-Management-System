namespace Warehouse_Management_System
{
    partial class UzytkownicyUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nazwiskoTb = new MetroFramework.Controls.MetroTextBox();
            this.imieTb = new MetroFramework.Controls.MetroTextBox();
            this.loginTb = new MetroFramework.Controls.MetroTextBox();
            this.uprawnieniaCb = new MetroFramework.Controls.MetroComboBox();
            this.zapiszBtn = new MetroFramework.Controls.MetroButton();
            this.usunBtn = new MetroFramework.Controls.MetroButton();
            this.hasloTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nazwisko:";
            // 
            // nazwiskoTb
            // 
            this.nazwiskoTb.Location = new System.Drawing.Point(3, 22);
            this.nazwiskoTb.Name = "nazwiskoTb";
            this.nazwiskoTb.Size = new System.Drawing.Size(94, 23);
            this.nazwiskoTb.TabIndex = 1;
            // 
            // imieTb
            // 
            this.imieTb.Location = new System.Drawing.Point(103, 22);
            this.imieTb.Name = "imieTb";
            this.imieTb.Size = new System.Drawing.Size(92, 23);
            this.imieTb.TabIndex = 2;
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(201, 22);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(75, 23);
            this.loginTb.TabIndex = 3;
            // 
            // uprawnieniaCb
            // 
            this.uprawnieniaCb.FormattingEnabled = true;
            this.uprawnieniaCb.ItemHeight = 23;
            this.uprawnieniaCb.Location = new System.Drawing.Point(363, 19);
            this.uprawnieniaCb.Name = "uprawnieniaCb";
            this.uprawnieniaCb.Size = new System.Drawing.Size(121, 29);
            this.uprawnieniaCb.TabIndex = 4;
            // 
            // zapiszBtn
            // 
            this.zapiszBtn.Location = new System.Drawing.Point(490, 22);
            this.zapiszBtn.Name = "zapiszBtn";
            this.zapiszBtn.Size = new System.Drawing.Size(50, 23);
            this.zapiszBtn.TabIndex = 5;
            this.zapiszBtn.Text = "Zapisz";
            this.zapiszBtn.Click += new System.EventHandler(this.zapiszBtn_Click);
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(546, 22);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(48, 23);
            this.usunBtn.TabIndex = 6;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // hasloTb
            // 
            this.hasloTb.Location = new System.Drawing.Point(282, 22);
            this.hasloTb.Name = "hasloTb";
            this.hasloTb.PasswordChar = '●';
            this.hasloTb.Size = new System.Drawing.Size(75, 23);
            this.hasloTb.TabIndex = 7;
            this.hasloTb.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(103, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Imię:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(201, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Login:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(282, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Hasło:";
            // 
            // UzytkownicyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.hasloTb);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.zapiszBtn);
            this.Controls.Add(this.uprawnieniaCb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.imieTb);
            this.Controls.Add(this.nazwiskoTb);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UzytkownicyUserControl";
            this.Size = new System.Drawing.Size(597, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nazwiskoTb;
        private MetroFramework.Controls.MetroTextBox imieTb;
        private MetroFramework.Controls.MetroTextBox loginTb;
        private MetroFramework.Controls.MetroComboBox uprawnieniaCb;
        private MetroFramework.Controls.MetroButton zapiszBtn;
        private MetroFramework.Controls.MetroButton usunBtn;
        private MetroFramework.Controls.MetroTextBox hasloTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
