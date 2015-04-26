namespace Warehouse_Management_System
{
    partial class ProduktyNaFakturzeUserControl
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
            this.nazwaTb = new MetroFramework.Controls.MetroTextBox();
            this.kodTb = new MetroFramework.Controls.MetroTextBox();
            this.cenaNettoTb = new MetroFramework.Controls.MetroTextBox();
            this.sumaCenaNettoTb = new MetroFramework.Controls.MetroTextBox();
            this.iloscTb = new MetroFramework.Controls.MetroTextBox();
            this.usunBtn = new MetroFramework.Controls.MetroButton();
            this.vatTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // nazwaTb
            // 
            this.nazwaTb.Enabled = false;
            this.nazwaTb.Location = new System.Drawing.Point(3, 3);
            this.nazwaTb.Name = "nazwaTb";
            this.nazwaTb.Size = new System.Drawing.Size(191, 23);
            this.nazwaTb.TabIndex = 0;
            // 
            // kodTb
            // 
            this.kodTb.Enabled = false;
            this.kodTb.Location = new System.Drawing.Point(200, 3);
            this.kodTb.Name = "kodTb";
            this.kodTb.Size = new System.Drawing.Size(75, 23);
            this.kodTb.TabIndex = 0;
            // 
            // cenaNettoTb
            // 
            this.cenaNettoTb.Enabled = false;
            this.cenaNettoTb.Location = new System.Drawing.Point(354, 3);
            this.cenaNettoTb.Name = "cenaNettoTb";
            this.cenaNettoTb.Size = new System.Drawing.Size(67, 23);
            this.cenaNettoTb.TabIndex = 0;
            // 
            // sumaCenaNettoTb
            // 
            this.sumaCenaNettoTb.Enabled = false;
            this.sumaCenaNettoTb.Location = new System.Drawing.Point(281, 3);
            this.sumaCenaNettoTb.Name = "sumaCenaNettoTb";
            this.sumaCenaNettoTb.Size = new System.Drawing.Size(67, 23);
            this.sumaCenaNettoTb.TabIndex = 0;
            // 
            // iloscTb
            // 
            this.iloscTb.Location = new System.Drawing.Point(427, 3);
            this.iloscTb.Name = "iloscTb";
            this.iloscTb.Size = new System.Drawing.Size(55, 23);
            this.iloscTb.TabIndex = 0;
            this.iloscTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iloscTb.TextChanged += new System.EventHandler(this.iloscTb_TextChanged);
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(547, 3);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(58, 23);
            this.usunBtn.TabIndex = 1;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // vatTb
            // 
            this.vatTb.Enabled = false;
            this.vatTb.Location = new System.Drawing.Point(488, 3);
            this.vatTb.Name = "vatTb";
            this.vatTb.Size = new System.Drawing.Size(27, 23);
            this.vatTb.TabIndex = 2;
            this.vatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(521, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "%";
            // 
            // ProduktyNaFakturzeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.vatTb);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.iloscTb);
            this.Controls.Add(this.sumaCenaNettoTb);
            this.Controls.Add(this.cenaNettoTb);
            this.Controls.Add(this.kodTb);
            this.Controls.Add(this.nazwaTb);
            this.Name = "ProduktyNaFakturzeUserControl";
            this.Size = new System.Drawing.Size(608, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nazwaTb;
        private MetroFramework.Controls.MetroTextBox kodTb;
        private MetroFramework.Controls.MetroTextBox cenaNettoTb;
        private MetroFramework.Controls.MetroTextBox sumaCenaNettoTb;
        private MetroFramework.Controls.MetroTextBox iloscTb;
        private MetroFramework.Controls.MetroButton usunBtn;
        private MetroFramework.Controls.MetroTextBox vatTb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
