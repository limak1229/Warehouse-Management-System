namespace Warehouse_Management_System
{
    partial class NowyProduktForm
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
            this.nazwaTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.kodTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cenaTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.iloscTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.ZapiszBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.vatTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Nazwa:";
            // 
            // nazwaTb
            // 
            this.nazwaTb.CustomBackground = true;
            this.nazwaTb.Location = new System.Drawing.Point(105, 63);
            this.nazwaTb.Name = "nazwaTb";
            this.nazwaTb.Size = new System.Drawing.Size(106, 23);
            this.nazwaTb.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Kod:";
            // 
            // kodTb
            // 
            this.kodTb.CustomBackground = true;
            this.kodTb.Location = new System.Drawing.Point(105, 121);
            this.kodTb.Name = "kodTb";
            this.kodTb.Size = new System.Drawing.Size(73, 23);
            this.kodTb.TabIndex = 2;
            this.kodTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kodTb_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Cena netto:";
            // 
            // cenaTb
            // 
            this.cenaTb.CustomBackground = true;
            this.cenaTb.Location = new System.Drawing.Point(105, 150);
            this.cenaTb.Name = "cenaTb";
            this.cenaTb.Size = new System.Drawing.Size(73, 23);
            this.cenaTb.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 179);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Ilość:";
            // 
            // iloscTb
            // 
            this.iloscTb.CustomBackground = true;
            this.iloscTb.Location = new System.Drawing.Point(105, 179);
            this.iloscTb.Name = "iloscTb";
            this.iloscTb.Size = new System.Drawing.Size(73, 23);
            this.iloscTb.TabIndex = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(184, 152);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(18, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "zł";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(184, 181);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(27, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "szt.";
            // 
            // ZapiszBtn
            // 
            this.ZapiszBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZapiszBtn.Location = new System.Drawing.Point(150, 211);
            this.ZapiszBtn.Name = "ZapiszBtn";
            this.ZapiszBtn.Size = new System.Drawing.Size(75, 23);
            this.ZapiszBtn.TabIndex = 5;
            this.ZapiszBtn.Text = "Zapisz";
            this.ZapiszBtn.Click += new System.EventHandler(this.ZapiszBtn_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(64, 92);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "VAT:";
            // 
            // vatTb
            // 
            this.vatTb.CustomBackground = true;
            this.vatTb.Location = new System.Drawing.Point(105, 92);
            this.vatTb.Name = "vatTb";
            this.vatTb.Size = new System.Drawing.Size(30, 23);
            this.vatTb.TabIndex = 2;
            this.vatTb.Text = "23";
            this.vatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vatTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kodTb_KeyUp);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(141, 94);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(20, 19);
            this.metroLabel8.TabIndex = 32;
            this.metroLabel8.Text = "%";
            // 
            // NowyProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(248, 251);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.ZapiszBtn);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.iloscTb);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cenaTb);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.vatTb);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.kodTb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.nazwaTb);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "NowyProduktForm";
            this.Resizable = false;
            this.Text = "Nowy Produkt";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NowyProduktForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nazwaTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox kodTb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox cenaTb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox iloscTb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton ZapiszBtn;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox vatTb;
        private MetroFramework.Controls.MetroLabel metroLabel8;

    }
}