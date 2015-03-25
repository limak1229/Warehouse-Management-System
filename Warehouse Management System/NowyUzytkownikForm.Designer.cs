namespace Warehouse_Management_System
{
    partial class NowyUzytkownikForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.typComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.zapiszButton = new MetroFramework.Controls.MetroButton();
            this.imieTb = new MetroFramework.Controls.MetroTextBox();
            this.nazwiskoTb = new MetroFramework.Controls.MetroTextBox();
            this.loginTb = new MetroFramework.Controls.MetroTextBox();
            this.hasloTb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Imie:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Nazwisko:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(45, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Login:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 150);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Hasło:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(57, 183);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(32, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Typ:";
            // 
            // typComboBox
            // 
            this.typComboBox.FormattingEnabled = true;
            this.typComboBox.ItemHeight = 23;
            this.typComboBox.Location = new System.Drawing.Point(96, 179);
            this.typComboBox.Name = "typComboBox";
            this.typComboBox.Size = new System.Drawing.Size(121, 29);
            this.typComboBox.TabIndex = 22;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 241);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Text = "Anuluj";
            // 
            // zapiszButton
            // 
            this.zapiszButton.Location = new System.Drawing.Point(163, 241);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(75, 23);
            this.zapiszButton.TabIndex = 24;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
            // 
            // imieTb
            // 
            this.imieTb.Location = new System.Drawing.Point(95, 63);
            this.imieTb.Name = "imieTb";
            this.imieTb.Size = new System.Drawing.Size(122, 23);
            this.imieTb.TabIndex = 25;
            // 
            // nazwiskoTb
            // 
            this.nazwiskoTb.Location = new System.Drawing.Point(95, 92);
            this.nazwiskoTb.Name = "nazwiskoTb";
            this.nazwiskoTb.Size = new System.Drawing.Size(122, 23);
            this.nazwiskoTb.TabIndex = 26;
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(95, 121);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(122, 23);
            this.loginTb.TabIndex = 27;
            // 
            // hasloTb
            // 
            this.hasloTb.Location = new System.Drawing.Point(95, 150);
            this.hasloTb.Name = "hasloTb";
            this.hasloTb.PasswordChar = '●';
            this.hasloTb.Size = new System.Drawing.Size(122, 23);
            this.hasloTb.TabIndex = 28;
            this.hasloTb.UseSystemPasswordChar = true;
            // 
            // NowyUzytkownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(261, 287);
            this.Controls.Add(this.hasloTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.nazwiskoTb);
            this.Controls.Add(this.imieTb);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.typComboBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NowyUzytkownikForm";
            this.Resizable = false;
            this.Text = "Nowy Uzytkownik";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NowyUzytkownikForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox typComboBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton zapiszButton;
        private MetroFramework.Controls.MetroTextBox imieTb;
        private MetroFramework.Controls.MetroTextBox nazwiskoTb;
        private MetroFramework.Controls.MetroTextBox loginTb;
        private MetroFramework.Controls.MetroTextBox hasloTb;

    }
}