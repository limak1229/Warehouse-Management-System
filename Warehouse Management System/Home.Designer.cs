﻿namespace Warehouse_Management_System
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.FakturyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.UsunFaktureButton = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DodajFaktureButton = new MetroFramework.Controls.MetroButton();
            this.ProduktyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.KlienciTabPage = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.UżytkownicyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.UstawieniaTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl.SuspendLayout();
            this.FakturyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ProduktyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.KlienciTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.UżytkownicyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.UstawieniaTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.FakturyTabPage);
            this.metroTabControl.Controls.Add(this.ProduktyTabPage);
            this.metroTabControl.Controls.Add(this.KlienciTabPage);
            this.metroTabControl.Controls.Add(this.UżytkownicyTabPage);
            this.metroTabControl.Controls.Add(this.UstawieniaTabPage);
            this.metroTabControl.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(616, 254);
            this.metroTabControl.TabIndex = 0;
            // 
            // FakturyTabPage
            // 
            this.FakturyTabPage.Controls.Add(this.UsunFaktureButton);
            this.FakturyTabPage.Controls.Add(this.dataGridView1);
            this.FakturyTabPage.Controls.Add(this.DodajFaktureButton);
            this.FakturyTabPage.HorizontalScrollbarBarColor = true;
            this.FakturyTabPage.Location = new System.Drawing.Point(4, 35);
            this.FakturyTabPage.Name = "FakturyTabPage";
            this.FakturyTabPage.Size = new System.Drawing.Size(608, 215);
            this.FakturyTabPage.TabIndex = 0;
            this.FakturyTabPage.Text = "Faktury";
            this.FakturyTabPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FakturyTabPage.VerticalScrollbarBarColor = true;
            // 
            // UsunFaktureButton
            // 
            this.UsunFaktureButton.Location = new System.Drawing.Point(111, 3);
            this.UsunFaktureButton.Name = "UsunFaktureButton";
            this.UsunFaktureButton.Size = new System.Drawing.Size(89, 23);
            this.UsunFaktureButton.TabIndex = 4;
            this.UsunFaktureButton.Text = "Usuń fakture";
            // 
            // dataGridView1
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.dataGridView1, true);
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 187);
            this.dataGridView1.TabIndex = 3;
            // 
            // DodajFaktureButton
            // 
            this.DodajFaktureButton.Location = new System.Drawing.Point(4, 3);
            this.DodajFaktureButton.Name = "DodajFaktureButton";
            this.DodajFaktureButton.Size = new System.Drawing.Size(101, 23);
            this.DodajFaktureButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.DodajFaktureButton.TabIndex = 2;
            this.DodajFaktureButton.Text = "Dodaj fakture";
            this.DodajFaktureButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DodajFaktureButton.Click += new System.EventHandler(this.DodajFaktureButton_Click);
            // 
            // ProduktyTabPage
            // 
            this.ProduktyTabPage.Controls.Add(this.dataGridView2);
            this.ProduktyTabPage.Controls.Add(this.metroButton2);
            this.ProduktyTabPage.Controls.Add(this.metroButton1);
            this.ProduktyTabPage.HorizontalScrollbarBarColor = true;
            this.ProduktyTabPage.Location = new System.Drawing.Point(4, 35);
            this.ProduktyTabPage.Name = "ProduktyTabPage";
            this.ProduktyTabPage.Size = new System.Drawing.Size(608, 215);
            this.ProduktyTabPage.TabIndex = 1;
            this.ProduktyTabPage.Text = "Produkty";
            this.ProduktyTabPage.VerticalScrollbarBarColor = true;
            // 
            // dataGridView2
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.dataGridView2, true);
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(612, 187);
            this.dataGridView2.TabIndex = 6;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(110, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(89, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Usuń produkt";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Dodaj produkt";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // KlienciTabPage
            // 
            this.KlienciTabPage.Controls.Add(this.dataGridView3);
            this.KlienciTabPage.Controls.Add(this.metroButton3);
            this.KlienciTabPage.Controls.Add(this.metroButton4);
            this.KlienciTabPage.HorizontalScrollbarBarColor = true;
            this.KlienciTabPage.Location = new System.Drawing.Point(4, 35);
            this.KlienciTabPage.Name = "KlienciTabPage";
            this.KlienciTabPage.Size = new System.Drawing.Size(608, 215);
            this.KlienciTabPage.TabIndex = 2;
            this.KlienciTabPage.Text = "Klienci";
            this.KlienciTabPage.VerticalScrollbarBarColor = true;
            // 
            // dataGridView3
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.dataGridView3, true);
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 32);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(608, 187);
            this.dataGridView3.TabIndex = 9;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(110, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(89, 23);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Usuń klienta";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(3, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(101, 23);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton4.TabIndex = 7;
            this.metroButton4.Text = "Dodaj klienta";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // UżytkownicyTabPage
            // 
            this.UżytkownicyTabPage.Controls.Add(this.dataGridView4);
            this.UżytkownicyTabPage.Controls.Add(this.metroButton5);
            this.UżytkownicyTabPage.Controls.Add(this.metroButton6);
            this.UżytkownicyTabPage.HorizontalScrollbarBarColor = true;
            this.UżytkownicyTabPage.Location = new System.Drawing.Point(4, 35);
            this.UżytkownicyTabPage.Name = "UżytkownicyTabPage";
            this.UżytkownicyTabPage.Size = new System.Drawing.Size(608, 215);
            this.UżytkownicyTabPage.TabIndex = 3;
            this.UżytkownicyTabPage.Text = "Użytkownicy";
            this.UżytkownicyTabPage.VerticalScrollbarBarColor = true;
            // 
            // dataGridView4
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.dataGridView4, true);
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 32);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(608, 187);
            this.dataGridView4.TabIndex = 12;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(132, 3);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(119, 23);
            this.metroButton5.TabIndex = 11;
            this.metroButton5.Text = "Usuń użytkownika";
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(3, 3);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(123, 23);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton6.TabIndex = 10;
            this.metroButton6.Text = "Dodaj użytkownika";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // UstawieniaTabPage
            // 
            this.UstawieniaTabPage.Controls.Add(this.metroLabel8);
            this.UstawieniaTabPage.Controls.Add(this.metroButton7);
            this.UstawieniaTabPage.Controls.Add(this.metroTextBox7);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel7);
            this.UstawieniaTabPage.Controls.Add(this.metroTextBox6);
            this.UstawieniaTabPage.Controls.Add(this.metroTextBox5);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel6);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel5);
            this.UstawieniaTabPage.Controls.Add(this.metroTextBox4);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel4);
            this.UstawieniaTabPage.Controls.Add(this.metroTextBox3);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel3);
            this.UstawieniaTabPage.Controls.Add(this.metroTextBox2);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel2);
            this.UstawieniaTabPage.Controls.Add(this.metroTextBox1);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel1);
            this.UstawieniaTabPage.HorizontalScrollbarBarColor = true;
            this.UstawieniaTabPage.Location = new System.Drawing.Point(4, 35);
            this.UstawieniaTabPage.Name = "UstawieniaTabPage";
            this.UstawieniaTabPage.Size = new System.Drawing.Size(608, 215);
            this.UstawieniaTabPage.TabIndex = 4;
            this.UstawieniaTabPage.Text = "Ustawienia";
            this.UstawieniaTabPage.VerticalScrollbarBarColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(267, 13);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 19);
            this.metroLabel8.TabIndex = 91;
            this.metroLabel8.Text = "Dane naszej firmy";
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(530, 189);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(75, 23);
            this.metroButton7.TabIndex = 90;
            this.metroButton7.Text = "Zapisz";
            // 
            // metroTextBox7
            // 
            this.metroTextBox7.Location = new System.Drawing.Point(210, 74);
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.Size = new System.Drawing.Size(67, 23);
            this.metroTextBox7.TabIndex = 89;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(171, 74);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 19);
            this.metroLabel7.TabIndex = 88;
            this.metroLabel7.Text = "NIP:";
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(392, 132);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(65, 23);
            this.metroTextBox6.TabIndex = 87;
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(210, 132);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(135, 23);
            this.metroTextBox5.TabIndex = 86;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(351, 132);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 85;
            this.metroLabel6.Text = "Kod:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(153, 132);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 84;
            this.metroLabel5.Text = "Miasto:";
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(392, 103);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(65, 23);
            this.metroTextBox4.TabIndex = 83;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(291, 103);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 82;
            this.metroLabel4.Text = "Nr. mieszkania:";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(210, 103);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox3.TabIndex = 81;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(123, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 80;
            this.metroLabel3.Text = "Nr. budynku:";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(329, 73);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(128, 23);
            this.metroTextBox2.TabIndex = 79;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(283, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 78;
            this.metroLabel2.Text = "Ulica:";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(210, 45);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(247, 23);
            this.metroTextBox1.TabIndex = 77;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(153, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 76;
            this.metroLabel1.Text = "Nazwa:";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(502, 7);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(75, 23);
            this.metroButton8.TabIndex = 1;
            this.metroButton8.Text = "Wyloguj";
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(662, 340);
            this.Controls.Add(this.metroButton8);
            this.Controls.Add(this.metroTabControl);
            this.Name = "HomeForm";
            this.Resizable = false;
            this.Text = "Warehouse Management System";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.metroTabControl.ResumeLayout(false);
            this.FakturyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ProduktyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.KlienciTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.UżytkownicyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.UstawieniaTabPage.ResumeLayout(false);
            this.UstawieniaTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage FakturyTabPage;
        private MetroFramework.Controls.MetroTabPage ProduktyTabPage;
        private MetroFramework.Controls.MetroTabPage KlienciTabPage;
        private MetroFramework.Controls.MetroTabPage UżytkownicyTabPage;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Controls.MetroTabPage UstawieniaTabPage;
        private MetroFramework.Controls.MetroButton DodajFaktureButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton UsunFaktureButton;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton8;



    }
}

