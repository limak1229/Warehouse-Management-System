namespace Warehouse_Management_System
{
    partial class ListaProduktowForm
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
            this.dodajBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.iloscTb = new MetroFramework.Controls.MetroTextBox();
            this.ProduktyFakturaMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.szukajProduktTb = new MetroFramework.Controls.MetroTextBox();
            this.szukajProduktuBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(308, 446);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 7;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(224, 448);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Ilość:";
            // 
            // iloscTb
            // 
            this.iloscTb.CustomBackground = true;
            this.iloscTb.Location = new System.Drawing.Point(267, 446);
            this.iloscTb.Name = "iloscTb";
            this.iloscTb.Size = new System.Drawing.Size(35, 23);
            this.iloscTb.TabIndex = 9;
            this.iloscTb.Text = "1";
            this.iloscTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProduktyFakturaMetroPanel
            // 
            this.ProduktyFakturaMetroPanel.AutoScroll = true;
            this.ProduktyFakturaMetroPanel.HorizontalScrollbar = true;
            this.ProduktyFakturaMetroPanel.HorizontalScrollbarBarColor = true;
            this.ProduktyFakturaMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ProduktyFakturaMetroPanel.HorizontalScrollbarSize = 10;
            this.ProduktyFakturaMetroPanel.Location = new System.Drawing.Point(23, 130);
            this.ProduktyFakturaMetroPanel.Name = "ProduktyFakturaMetroPanel";
            this.ProduktyFakturaMetroPanel.Size = new System.Drawing.Size(362, 310);
            this.ProduktyFakturaMetroPanel.TabIndex = 10;
            this.ProduktyFakturaMetroPanel.VerticalScrollbar = true;
            this.ProduktyFakturaMetroPanel.VerticalScrollbarBarColor = true;
            this.ProduktyFakturaMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ProduktyFakturaMetroPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(66, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Nazwa";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(180, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(32, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Kod";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(248, 108);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Cena";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(311, 108);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(34, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Stan";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 89);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(316, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Wybierz produkt a następnie wprowadź ilość poniżej";
            // 
            // szukajProduktTb
            // 
            this.szukajProduktTb.Location = new System.Drawing.Point(186, 63);
            this.szukajProduktTb.Name = "szukajProduktTb";
            this.szukajProduktTb.Size = new System.Drawing.Size(75, 23);
            this.szukajProduktTb.TabIndex = 13;
            // 
            // szukajProduktuBtn
            // 
            this.szukajProduktuBtn.Location = new System.Drawing.Point(267, 63);
            this.szukajProduktuBtn.Name = "szukajProduktuBtn";
            this.szukajProduktuBtn.Size = new System.Drawing.Size(55, 23);
            this.szukajProduktuBtn.TabIndex = 14;
            this.szukajProduktuBtn.Text = "Szukaj";
            this.szukajProduktuBtn.Click += new System.EventHandler(this.szukajProduktuBtn_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(24, 64);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(156, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Wprowadź kod produktu";
            // 
            // ListaProduktowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(408, 492);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.szukajProduktuBtn);
            this.Controls.Add(this.szukajProduktTb);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ProduktyFakturaMetroPanel);
            this.Controls.Add(this.iloscTb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dodajBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ListaProduktowForm";
            this.Resizable = false;
            this.Text = "Lista Produktów";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.ListaProduktowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton dodajBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox iloscTb;
        private MetroFramework.Controls.MetroPanel ProduktyFakturaMetroPanel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox szukajProduktTb;
        private MetroFramework.Controls.MetroButton szukajProduktuBtn;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}