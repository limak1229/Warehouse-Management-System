namespace Warehouse_Management_System
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
            this.MetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.FakturyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.UsunFaktureButton = new MetroFramework.Controls.MetroButton();
            this.DodajFaktureBtn = new MetroFramework.Controls.MetroButton();
            this.UzytkownicyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.UzytkownicyMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.iloscUzytkownikowLabel = new MetroFramework.Controls.MetroLabel();
            this.DodajUzytkownikaBtn = new MetroFramework.Controls.MetroButton();
            this.ProduktyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ProduktyMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.iloscProduktowLabel = new MetroFramework.Controls.MetroLabel();
            this.DodajProduktBtn = new MetroFramework.Controls.MetroButton();
            this.UstawieniaTabPage = new MetroFramework.Controls.MetroTabPage();
            this.zapiszBtn = new MetroFramework.Controls.MetroButton();
            this.nipFTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.kodFTb = new MetroFramework.Controls.MetroTextBox();
            this.miastoFTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numerMFTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.numerBFTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ulicaFTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nazwaFTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.KlienciTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.DodajKlientaBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.WylogujBtn = new MetroFramework.Controls.MetroButton();
            this.userInfolabel = new MetroFramework.Controls.MetroLabel();
            this.MetroTabControl.SuspendLayout();
            this.FakturyTabPage.SuspendLayout();
            this.UzytkownicyTabPage.SuspendLayout();
            this.ProduktyTabPage.SuspendLayout();
            this.UstawieniaTabPage.SuspendLayout();
            this.KlienciTabPage.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MetroTabControl
            // 
            this.MetroTabControl.Controls.Add(this.FakturyTabPage);
            this.MetroTabControl.Controls.Add(this.UstawieniaTabPage);
            this.MetroTabControl.Controls.Add(this.UzytkownicyTabPage);
            this.MetroTabControl.Controls.Add(this.ProduktyTabPage);
            this.MetroTabControl.Controls.Add(this.KlienciTabPage);
            this.MetroTabControl.Controls.Add(this.metroTabPage1);
            this.MetroTabControl.Location = new System.Drawing.Point(23, 63);
            this.MetroTabControl.Name = "MetroTabControl";
            this.MetroTabControl.SelectedIndex = 1;
            this.MetroTabControl.Size = new System.Drawing.Size(616, 347);
            this.MetroTabControl.TabIndex = 0;
            // 
            // FakturyTabPage
            // 
            this.FakturyTabPage.Controls.Add(this.metroButton1);
            this.FakturyTabPage.Controls.Add(this.UsunFaktureButton);
            this.FakturyTabPage.Controls.Add(this.DodajFaktureBtn);
            this.FakturyTabPage.HorizontalScrollbarBarColor = true;
            this.FakturyTabPage.Location = new System.Drawing.Point(4, 35);
            this.FakturyTabPage.Name = "FakturyTabPage";
            this.FakturyTabPage.Size = new System.Drawing.Size(608, 308);
            this.FakturyTabPage.TabIndex = 0;
            this.FakturyTabPage.Text = "Faktury";
            this.FakturyTabPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FakturyTabPage.VerticalScrollbarBarColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(111, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Zapisz fakture";
            // 
            // UsunFaktureButton
            // 
            this.UsunFaktureButton.Location = new System.Drawing.Point(212, 3);
            this.UsunFaktureButton.Name = "UsunFaktureButton";
            this.UsunFaktureButton.Size = new System.Drawing.Size(89, 23);
            this.UsunFaktureButton.TabIndex = 0;
            this.UsunFaktureButton.Text = "Usuń fakture";
            // 
            // DodajFaktureBtn
            // 
            this.DodajFaktureBtn.Location = new System.Drawing.Point(4, 3);
            this.DodajFaktureBtn.Name = "DodajFaktureBtn";
            this.DodajFaktureBtn.Size = new System.Drawing.Size(101, 23);
            this.DodajFaktureBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.DodajFaktureBtn.TabIndex = 2;
            this.DodajFaktureBtn.Text = "Dodaj fakture";
            this.DodajFaktureBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DodajFaktureBtn.Click += new System.EventHandler(this.DodajFaktureBtn_Click);
            // 
            // UzytkownicyTabPage
            // 
            this.UzytkownicyTabPage.Controls.Add(this.UzytkownicyMetroPanel);
            this.UzytkownicyTabPage.Controls.Add(this.iloscUzytkownikowLabel);
            this.UzytkownicyTabPage.Controls.Add(this.DodajUzytkownikaBtn);
            this.UzytkownicyTabPage.HorizontalScrollbarBarColor = true;
            this.UzytkownicyTabPage.Location = new System.Drawing.Point(4, 35);
            this.UzytkownicyTabPage.Name = "UzytkownicyTabPage";
            this.UzytkownicyTabPage.Size = new System.Drawing.Size(608, 308);
            this.UzytkownicyTabPage.TabIndex = 3;
            this.UzytkownicyTabPage.Text = "Użytkownicy";
            this.UzytkownicyTabPage.VerticalScrollbarBarColor = true;
            // 
            // UzytkownicyMetroPanel
            // 
            this.UzytkownicyMetroPanel.AutoScroll = true;
            this.UzytkownicyMetroPanel.HorizontalScrollbar = true;
            this.UzytkownicyMetroPanel.HorizontalScrollbarBarColor = true;
            this.UzytkownicyMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.UzytkownicyMetroPanel.HorizontalScrollbarSize = 10;
            this.UzytkownicyMetroPanel.Location = new System.Drawing.Point(0, 32);
            this.UzytkownicyMetroPanel.Name = "UzytkownicyMetroPanel";
            this.UzytkownicyMetroPanel.Size = new System.Drawing.Size(608, 273);
            this.UzytkownicyMetroPanel.TabIndex = 14;
            this.UzytkownicyMetroPanel.VerticalScrollbar = true;
            this.UzytkownicyMetroPanel.VerticalScrollbarBarColor = true;
            this.UzytkownicyMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.UzytkownicyMetroPanel.VerticalScrollbarSize = 10;
            // 
            // iloscUzytkownikowLabel
            // 
            this.iloscUzytkownikowLabel.AutoSize = true;
            this.iloscUzytkownikowLabel.Location = new System.Drawing.Point(132, 5);
            this.iloscUzytkownikowLabel.Name = "iloscUzytkownikowLabel";
            this.iloscUzytkownikowLabel.Size = new System.Drawing.Size(94, 19);
            this.iloscUzytkownikowLabel.TabIndex = 13;
            this.iloscUzytkownikowLabel.Text = "ilość rekordów";
            // 
            // DodajUzytkownikaBtn
            // 
            this.DodajUzytkownikaBtn.Location = new System.Drawing.Point(3, 3);
            this.DodajUzytkownikaBtn.Name = "DodajUzytkownikaBtn";
            this.DodajUzytkownikaBtn.Size = new System.Drawing.Size(123, 23);
            this.DodajUzytkownikaBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.DodajUzytkownikaBtn.TabIndex = 10;
            this.DodajUzytkownikaBtn.Text = "Dodaj użytkownika";
            this.DodajUzytkownikaBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DodajUzytkownikaBtn.Click += new System.EventHandler(this.DodajUzytkownikaBtn_Click);
            // 
            // ProduktyTabPage
            // 
            this.ProduktyTabPage.Controls.Add(this.ProduktyMetroPanel);
            this.ProduktyTabPage.Controls.Add(this.iloscProduktowLabel);
            this.ProduktyTabPage.Controls.Add(this.DodajProduktBtn);
            this.ProduktyTabPage.HorizontalScrollbar = true;
            this.ProduktyTabPage.HorizontalScrollbarBarColor = true;
            this.ProduktyTabPage.Location = new System.Drawing.Point(4, 35);
            this.ProduktyTabPage.Name = "ProduktyTabPage";
            this.ProduktyTabPage.Size = new System.Drawing.Size(608, 308);
            this.ProduktyTabPage.TabIndex = 1;
            this.ProduktyTabPage.Text = "Produkty";
            this.ProduktyTabPage.VerticalScrollbar = true;
            this.ProduktyTabPage.VerticalScrollbarBarColor = true;
            // 
            // ProduktyMetroPanel
            // 
            this.ProduktyMetroPanel.AutoScroll = true;
            this.ProduktyMetroPanel.HorizontalScrollbar = true;
            this.ProduktyMetroPanel.HorizontalScrollbarBarColor = true;
            this.ProduktyMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ProduktyMetroPanel.HorizontalScrollbarSize = 10;
            this.ProduktyMetroPanel.Location = new System.Drawing.Point(0, 32);
            this.ProduktyMetroPanel.Name = "ProduktyMetroPanel";
            this.ProduktyMetroPanel.Size = new System.Drawing.Size(608, 273);
            this.ProduktyMetroPanel.TabIndex = 4;
            this.ProduktyMetroPanel.VerticalScrollbar = true;
            this.ProduktyMetroPanel.VerticalScrollbarBarColor = true;
            this.ProduktyMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ProduktyMetroPanel.VerticalScrollbarSize = 10;
            // 
            // iloscProduktowLabel
            // 
            this.iloscProduktowLabel.AutoSize = true;
            this.iloscProduktowLabel.Location = new System.Drawing.Point(110, 5);
            this.iloscProduktowLabel.Name = "iloscProduktowLabel";
            this.iloscProduktowLabel.Size = new System.Drawing.Size(94, 19);
            this.iloscProduktowLabel.TabIndex = 3;
            this.iloscProduktowLabel.Text = "ilość rekordów";
            // 
            // DodajProduktBtn
            // 
            this.DodajProduktBtn.Location = new System.Drawing.Point(3, 3);
            this.DodajProduktBtn.Name = "DodajProduktBtn";
            this.DodajProduktBtn.Size = new System.Drawing.Size(101, 23);
            this.DodajProduktBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.DodajProduktBtn.TabIndex = 3;
            this.DodajProduktBtn.Text = "Dodaj produkt";
            this.DodajProduktBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DodajProduktBtn.Click += new System.EventHandler(this.DodajProduktBtn_Click);
            // 
            // UstawieniaTabPage
            // 
            this.UstawieniaTabPage.Controls.Add(this.zapiszBtn);
            this.UstawieniaTabPage.Controls.Add(this.nipFTb);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel7);
            this.UstawieniaTabPage.Controls.Add(this.kodFTb);
            this.UstawieniaTabPage.Controls.Add(this.miastoFTb);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel6);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel5);
            this.UstawieniaTabPage.Controls.Add(this.numerMFTb);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel4);
            this.UstawieniaTabPage.Controls.Add(this.numerBFTb);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel3);
            this.UstawieniaTabPage.Controls.Add(this.ulicaFTb);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel2);
            this.UstawieniaTabPage.Controls.Add(this.nazwaFTb);
            this.UstawieniaTabPage.Controls.Add(this.metroLabel1);
            this.UstawieniaTabPage.HorizontalScrollbarBarColor = true;
            this.UstawieniaTabPage.Location = new System.Drawing.Point(4, 35);
            this.UstawieniaTabPage.Name = "UstawieniaTabPage";
            this.UstawieniaTabPage.Size = new System.Drawing.Size(608, 308);
            this.UstawieniaTabPage.TabIndex = 4;
            this.UstawieniaTabPage.Text = "Dane firmy";
            this.UstawieniaTabPage.VerticalScrollbarBarColor = true;
            // 
            // zapiszBtn
            // 
            this.zapiszBtn.Location = new System.Drawing.Point(363, 161);
            this.zapiszBtn.Name = "zapiszBtn";
            this.zapiszBtn.Size = new System.Drawing.Size(75, 23);
            this.zapiszBtn.TabIndex = 90;
            this.zapiszBtn.Text = "Zapisz";
            this.zapiszBtn.Click += new System.EventHandler(this.zapiszBtn_Click);
            // 
            // nipFTb
            // 
            this.nipFTb.Location = new System.Drawing.Point(210, 74);
            this.nipFTb.Name = "nipFTb";
            this.nipFTb.Size = new System.Drawing.Size(67, 23);
            this.nipFTb.TabIndex = 89;
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
            // kodFTb
            // 
            this.kodFTb.Location = new System.Drawing.Point(392, 132);
            this.kodFTb.Name = "kodFTb";
            this.kodFTb.Size = new System.Drawing.Size(65, 23);
            this.kodFTb.TabIndex = 87;
            // 
            // miastoFTb
            // 
            this.miastoFTb.Location = new System.Drawing.Point(210, 132);
            this.miastoFTb.Name = "miastoFTb";
            this.miastoFTb.Size = new System.Drawing.Size(135, 23);
            this.miastoFTb.TabIndex = 86;
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
            // numerMFTb
            // 
            this.numerMFTb.Location = new System.Drawing.Point(392, 103);
            this.numerMFTb.Name = "numerMFTb";
            this.numerMFTb.Size = new System.Drawing.Size(65, 23);
            this.numerMFTb.TabIndex = 83;
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
            // numerBFTb
            // 
            this.numerBFTb.Location = new System.Drawing.Point(210, 103);
            this.numerBFTb.Name = "numerBFTb";
            this.numerBFTb.Size = new System.Drawing.Size(75, 23);
            this.numerBFTb.TabIndex = 81;
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
            // ulicaFTb
            // 
            this.ulicaFTb.Location = new System.Drawing.Point(329, 73);
            this.ulicaFTb.Name = "ulicaFTb";
            this.ulicaFTb.Size = new System.Drawing.Size(128, 23);
            this.ulicaFTb.TabIndex = 79;
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
            // nazwaFTb
            // 
            this.nazwaFTb.Location = new System.Drawing.Point(210, 45);
            this.nazwaFTb.Name = "nazwaFTb";
            this.nazwaFTb.Size = new System.Drawing.Size(247, 23);
            this.nazwaFTb.TabIndex = 77;
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
            // KlienciTabPage
            // 
            this.KlienciTabPage.Controls.Add(this.metroButton3);
            this.KlienciTabPage.Controls.Add(this.DodajKlientaBtn);
            this.KlienciTabPage.HorizontalScrollbarBarColor = true;
            this.KlienciTabPage.Location = new System.Drawing.Point(4, 35);
            this.KlienciTabPage.Name = "KlienciTabPage";
            this.KlienciTabPage.Size = new System.Drawing.Size(608, 308);
            this.KlienciTabPage.TabIndex = 2;
            this.KlienciTabPage.Text = "Klienci";
            this.KlienciTabPage.VerticalScrollbarBarColor = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(110, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(89, 23);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Usuń klienta";
            // 
            // DodajKlientaBtn
            // 
            this.DodajKlientaBtn.Location = new System.Drawing.Point(3, 3);
            this.DodajKlientaBtn.Name = "DodajKlientaBtn";
            this.DodajKlientaBtn.Size = new System.Drawing.Size(101, 23);
            this.DodajKlientaBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.DodajKlientaBtn.TabIndex = 7;
            this.DodajKlientaBtn.Text = "Dodaj klienta";
            this.DodajKlientaBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DodajKlientaBtn.Click += new System.EventHandler(this.DodajKlientaBtn_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dateTimePicker2);
            this.metroTabPage1.Controls.Add(this.dateTimePicker1);
            this.metroTabPage1.Controls.Add(this.metroButton4);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(608, 308);
            this.metroTabPage1.TabIndex = 5;
            this.metroTabPage1.Text = "Zestawienia";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(267, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker2.TabIndex = 73;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 72;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(247, 96);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(128, 23);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Zapisz zestawienie";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(166, 70);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(95, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Data Końcowa:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(150, 44);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(111, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Data Początkowa:";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // WylogujBtn
            // 
            this.WylogujBtn.Location = new System.Drawing.Point(502, 7);
            this.WylogujBtn.Name = "WylogujBtn";
            this.WylogujBtn.Size = new System.Drawing.Size(75, 23);
            this.WylogujBtn.TabIndex = 1;
            this.WylogujBtn.Text = "Wyloguj";
            this.WylogujBtn.Click += new System.EventHandler(this.WylogujBtn_Click);
            // 
            // userInfolabel
            // 
            this.userInfolabel.AutoSize = true;
            this.userInfolabel.Location = new System.Drawing.Point(23, 7);
            this.userInfolabel.Name = "userInfolabel";
            this.userInfolabel.Size = new System.Drawing.Size(83, 19);
            this.userInfolabel.TabIndex = 2;
            this.userInfolabel.Text = "userInfolabel";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(662, 433);
            this.Controls.Add(this.userInfolabel);
            this.Controls.Add(this.WylogujBtn);
            this.Controls.Add(this.MetroTabControl);
            this.Name = "HomeForm";
            this.Resizable = false;
            this.Text = "Warehouse Management System";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.MetroTabControl.ResumeLayout(false);
            this.FakturyTabPage.ResumeLayout(false);
            this.UzytkownicyTabPage.ResumeLayout(false);
            this.UzytkownicyTabPage.PerformLayout();
            this.ProduktyTabPage.ResumeLayout(false);
            this.ProduktyTabPage.PerformLayout();
            this.UstawieniaTabPage.ResumeLayout(false);
            this.UstawieniaTabPage.PerformLayout();
            this.KlienciTabPage.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MetroTabControl;
        private MetroFramework.Controls.MetroTabPage FakturyTabPage;
        private MetroFramework.Controls.MetroTabPage ProduktyTabPage;
        private MetroFramework.Controls.MetroTabPage KlienciTabPage;
        private MetroFramework.Controls.MetroTabPage UzytkownicyTabPage;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Controls.MetroTabPage UstawieniaTabPage;
        private MetroFramework.Controls.MetroButton DodajFaktureBtn;
        private MetroFramework.Controls.MetroButton UsunFaktureButton;
        private MetroFramework.Controls.MetroButton DodajProduktBtn;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton DodajKlientaBtn;
        private MetroFramework.Controls.MetroButton DodajUzytkownikaBtn;
        private MetroFramework.Controls.MetroButton zapiszBtn;
        private MetroFramework.Controls.MetroTextBox nipFTb;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox kodFTb;
        private MetroFramework.Controls.MetroTextBox miastoFTb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox numerMFTb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox numerBFTb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox ulicaFTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox nazwaFTb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton WylogujBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel userInfolabel;
        private MetroFramework.Controls.MetroLabel iloscProduktowLabel;
        private MetroFramework.Controls.MetroLabel iloscUzytkownikowLabel;
        public MetroFramework.Controls.MetroPanel ProduktyMetroPanel;
        public MetroFramework.Controls.MetroPanel UzytkownicyMetroPanel;



    }
}

