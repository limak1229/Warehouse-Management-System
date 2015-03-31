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
            this.nazwiskoTb = new MetroFramework.Controls.MetroTextBox();
            this.imieTb = new MetroFramework.Controls.MetroTextBox();
            this.loginTb = new MetroFramework.Controls.MetroTextBox();
            this.uprawnieniaCb = new MetroFramework.Controls.MetroComboBox();
            this.zapiszBtn = new MetroFramework.Controls.MetroButton();
            this.usunBtn = new MetroFramework.Controls.MetroButton();
            this.hasloTb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // nazwiskoTb
            // 
            this.nazwiskoTb.Location = new System.Drawing.Point(3, 6);
            this.nazwiskoTb.Name = "nazwiskoTb";
            this.nazwiskoTb.Size = new System.Drawing.Size(94, 23);
            this.nazwiskoTb.TabIndex = 1;
            // 
            // imieTb
            // 
            this.imieTb.Location = new System.Drawing.Point(103, 6);
            this.imieTb.Name = "imieTb";
            this.imieTb.Size = new System.Drawing.Size(92, 23);
            this.imieTb.TabIndex = 2;
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(201, 6);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(75, 23);
            this.loginTb.TabIndex = 3;
            // 
            // uprawnieniaCb
            // 
            this.uprawnieniaCb.FormattingEnabled = true;
            this.uprawnieniaCb.ItemHeight = 23;
            this.uprawnieniaCb.Location = new System.Drawing.Point(363, 3);
            this.uprawnieniaCb.Name = "uprawnieniaCb";
            this.uprawnieniaCb.Size = new System.Drawing.Size(121, 29);
            this.uprawnieniaCb.TabIndex = 4;
            // 
            // zapiszBtn
            // 
            this.zapiszBtn.Location = new System.Drawing.Point(490, 6);
            this.zapiszBtn.Name = "zapiszBtn";
            this.zapiszBtn.Size = new System.Drawing.Size(50, 23);
            this.zapiszBtn.TabIndex = 5;
            this.zapiszBtn.Text = "Zapisz";
            this.zapiszBtn.Click += new System.EventHandler(this.zapiszBtn_Click);
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(546, 6);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(48, 23);
            this.usunBtn.TabIndex = 6;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // hasloTb
            // 
            this.hasloTb.Location = new System.Drawing.Point(282, 6);
            this.hasloTb.Name = "hasloTb";
            this.hasloTb.PasswordChar = '●';
            this.hasloTb.Size = new System.Drawing.Size(75, 23);
            this.hasloTb.TabIndex = 7;
            this.hasloTb.UseSystemPasswordChar = true;
            // 
            // UzytkownicyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.hasloTb);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.zapiszBtn);
            this.Controls.Add(this.uprawnieniaCb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.imieTb);
            this.Controls.Add(this.nazwiskoTb);
            this.Name = "UzytkownicyUserControl";
            this.Size = new System.Drawing.Size(597, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nazwiskoTb;
        private MetroFramework.Controls.MetroTextBox imieTb;
        private MetroFramework.Controls.MetroTextBox loginTb;
        private MetroFramework.Controls.MetroComboBox uprawnieniaCb;
        private MetroFramework.Controls.MetroButton zapiszBtn;
        private MetroFramework.Controls.MetroButton usunBtn;
        private MetroFramework.Controls.MetroTextBox hasloTb;
    }
}
