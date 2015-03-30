using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management_System;

namespace Warehouse_Management_System
{
    public partial class HomeForm : MetroForm
    {
        bool logout = false;
        private Uzytkownicy zalogowanyUzytkownik;

        public HomeForm(Uzytkownicy zalogowanyUzytkownik)
        {
            this.zalogowanyUzytkownik = zalogowanyUzytkownik;
            InitializeComponent();
            iloscProduktowLabel.Text = iloscUzytkownikowLabel.Text = " ";
            userInfolabel.Text = "Jesteś zalogowany jako: " + zalogowanyUzytkownik.Imie.ToString() + " " + zalogowanyUzytkownik.Nazwisko.ToString();
        }
        private void DodajFaktureBtn_Click(object sender, EventArgs e)
        {
            NowaFakturaForm NowaFakturaForm = new NowaFakturaForm();
            NowaFakturaForm.ShowDialog();
        }

        private void DodajProduktBtn_Click(object sender, EventArgs e)
        {
            NowyProduktForm NowyProduktForm = new NowyProduktForm();
            NowyProduktForm.FormClosed += NowyProduktForm_FormClosed;
            NowyProduktForm.ShowDialog();
        }

        void NowyProduktForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WczytajProdukty();
        }

        private void DodajKlientaBtn_Click(object sender, EventArgs e)
        {
            Nowy_KlientForm NowyKlientForm = new Nowy_KlientForm();
            NowyKlientForm.ShowDialog();
        }

        private void DodajUzytkownikaBtn_Click(object sender, EventArgs e)
        {
            NowyUzytkownikForm NowyUzytkownikForm = new NowyUzytkownikForm();
            
            NowyUzytkownikForm.FormClosed += NowyUzytkownikForm_FormClosed;
            NowyUzytkownikForm.ShowDialog();
        }

        void NowyUzytkownikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WczytajUzytkownikow();
        }

        private void WylogujBtn_Click(object sender, EventArgs e)
        {
            this.logout = true;
            this.Close();
            Form LF = Application.OpenForms["LoginForm"];
            LF.Show();
            LF.Activate();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.logout)
            {
                Application.Exit();
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            WczytajUzytkownikow();
            WczytajProdukty();
            WczytajDaneFirmy();
        }

        public void WczytajUzytkownikow()
        {
            this.UzytkownicyTabPage.Controls.RemoveByKey("UzytkownicyMetroPanel");
            this.UzytkownicyTabPage.Controls.Add(this.UzytkownicyMetroPanel);
            Int32 i = 0;
            foreach (Uzytkownicy u in BazaDanych.Polaczenie.Uzytkownicies)
            {
                UzytkownicyUserControl UUC = new UzytkownicyUserControl(this, u);
                UUC.Location = new System.Drawing.Point(0, (i++) * (UUC.Height));
                UUC.Name = "uzytkownik" + i.ToString();
                this.UzytkownicyMetroPanel.Controls.Add(UUC);
            }
            iloscUzytkownikowLabel.Text = "Ilość użytkowników: " + i.ToString();
        }

        public void WczytajProdukty()
        {
            this.ProduktyTabPage.Controls.RemoveByKey("ProduktyMetroPanel");
            this.ProduktyTabPage.Controls.Add(this.ProduktyMetroPanel);
            Int32 i = 0;
            foreach (Produkty p in BazaDanych.Polaczenie.Produkties)
            {
                ProductUserControl PUC = new ProductUserControl(this, p);
                PUC.Location = new System.Drawing.Point(0, (i++) * (PUC.Height));
                PUC.Name = "produkt" + i.ToString();
                this.ProduktyMetroPanel.Controls.Add(PUC);
            }
            iloscProduktowLabel.Text = "Ilość produktów: " + i.ToString();
        }

        private void WczytajDaneFirmy()
        {
            Int32 lastId = BazaDanych.Polaczenie.DaneFirmies.Max(d => d.Id_firmy);
            DaneFirmy DaneFirmy = BazaDanych.Polaczenie.DaneFirmies.SingleOrDefault(d => d.Id_firmy == lastId);
            if (DaneFirmy != null)
            {
                nazwaFTb.Text = DaneFirmy.Nazwa;
                nipFTb.Text = DaneFirmy.Nip;
                ulicaFTb.Text = DaneFirmy.Ulica;
                numerBFTb.Text = DaneFirmy.Nr_budynku;
                numerMFTb.Text = DaneFirmy.Nr_mieszkania;
                miastoFTb.Text = DaneFirmy.Miasto;
                kodFTb.Text = DaneFirmy.Kod_pocztowy;
            }
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {
            DaneFirmy noweDane = new DaneFirmy();
            BazaDanych.Polaczenie.DaneFirmies.InsertOnSubmit(noweDane);
            noweDane.Nazwa = nazwaFTb.Text;
            noweDane.Nip = nipFTb.Text;
            noweDane.Ulica = ulicaFTb.Text;
            noweDane.Nr_budynku = numerBFTb.Text;
            noweDane.Nr_mieszkania = numerMFTb.Text;
            noweDane.Miasto = miastoFTb.Text;
            noweDane.Kod_pocztowy = kodFTb.Text;
            BazaDanych.Polaczenie.SubmitChanges();
            MessageBox.Show("Nowe dane zostały wprowadzone.","Edycja danych", MessageBoxButtons.OK);
        }
    }
}
