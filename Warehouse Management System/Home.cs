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
            NowaFakturaForm NowaFakturaForm = new NowaFakturaForm(zalogowanyUzytkownik);
            DialogResult result = NowaFakturaForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                WczytajProdukty();
                WczytajFaktury();
            }
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
            Nowy_KlientForm NowyKlientForm = new Nowy_KlientForm(this);
            NowyKlientForm.Show();
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
            WczytajKlientow();
            WczytajFaktury();
        }

        public void WczytajUzytkownikow()
        {
            var ListaElementow = this.UzytkownicyTabPage.Controls.Find("UzytkownicyMetroPanel", true).First().Controls.OfType<UzytkownicyUserControl>().ToList();
            foreach (var el in ListaElementow)
            {
                this.UzytkownicyMetroPanel.Controls.Remove(el);
            }
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
            var ListaElementow = this.ProduktyTabPage.Controls.Find("ProduktyMetroPanel", true).First().Controls.OfType<ProductUserControl>().ToList();
            foreach (var el in ListaElementow)
            {
                this.ProduktyMetroPanel.Controls.Remove(el);
            }
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

        public void WczytajKlientow()
        {
            var ListaElementow = this.KlienciTabPage.Controls.Find("KlienciMetroPanel", true).First().Controls.OfType<KlienciUserControl>().ToList();
            foreach (var el in ListaElementow)
            {
                this.KlienciMetroPanel.Controls.Remove(el);
            }
            Int32 i = 0;
            foreach (Klienci k in BazaDanych.Polaczenie.Kliencis)
            {
                KlienciUserControl KUC = new KlienciUserControl(this, k);
                KUC.Location = new System.Drawing.Point(0, (i++) * (KUC.Height));
                KUC.Name = "klient" + i.ToString();
                this.KlienciMetroPanel.Controls.Add(KUC);
            }
            iloscKlientowLabel.Text = "Ilość klientów: " + i.ToString();
        }

        public void WczytajFaktury()
        {
            var ListaElementow = this.FakturyTabPage.Controls.Find("FakturyMetroPanel", true).First().Controls.OfType<ListaFakturUserControl>().ToList();
            foreach (var el in ListaElementow)
            {
                this.FakturyMetroPanel.Controls.Remove(el);
            }
            Int32 i = 0;
            foreach (Faktury f in BazaDanych.Polaczenie.Fakturies.OrderByDescending(f => f.Id_faktury))
            {
                ListaFakturUserControl LFUC = new ListaFakturUserControl(this, f);
                LFUC.Location = new System.Drawing.Point(0, (i++) * (LFUC.Height));
                LFUC.Name = "faktura" + i.ToString();
                this.FakturyMetroPanel.Controls.Add(LFUC);
            }
            iloscFakturLabel.Text = "Ilość faktur: " + i.ToString();
        }

        private void WczytajDaneFirmy()
        {
            DaneFirmy DaneFirmy = Program.pobierzDaneFirmy();
            if (DaneFirmy != null)
            {
                nazwaTb.Text = DaneFirmy.Nazwa;
                nipTb.Text = DaneFirmy.Nip;
                ulicaTb.Text = DaneFirmy.Ulica;
                nrBudynkuTb.Text = DaneFirmy.Nr_budynku;
                nrMieszkaniaTb.Text = DaneFirmy.Nr_mieszkania;
                miastoTb.Text = DaneFirmy.Miasto;
                kodTb.Text = DaneFirmy.Kod_pocztowy;
            }
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {
            DaneFirmy noweDane = new DaneFirmy();
            if (nazwaTb.Text != string.Empty && nipTb.Text != string.Empty && ulicaTb.Text != string.Empty && nrBudynkuTb.Text != string.Empty && miastoTb.Text != string.Empty && kodTb.Text != string.Empty)
            {
                BazaDanych.Polaczenie.DaneFirmies.InsertOnSubmit(noweDane);
                noweDane.Nazwa = nazwaTb.Text;
                noweDane.Nip = nipTb.Text;
                noweDane.Ulica = ulicaTb.Text;
                noweDane.Nr_budynku = nrBudynkuTb.Text;
                noweDane.Nr_mieszkania = nrMieszkaniaTb.Text;
                noweDane.Miasto = miastoTb.Text;
                noweDane.Kod_pocztowy = kodTb.Text;
                BazaDanych.Polaczenie.SubmitChanges();
                MessageBox.Show("Nowe dane zostały wprowadzone.", "Edycja danych", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Wprowadź prawidłowe dane.", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
