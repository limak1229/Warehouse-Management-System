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

namespace Warehouse_Management_System
{
    public partial class NowaFakturaForm : MetroForm
    {
        List<Produkty_sprzedane> listaWybranychProduktow = new List<Produkty_sprzedane>();
        Faktury faktura = new Faktury();
        private Uzytkownicy zalogowanyUzytkownik;

        public NowaFakturaForm(Uzytkownicy zalogowanyUzytkownik)
        {
            InitializeComponent();
            this.zalogowanyUzytkownik = zalogowanyUzytkownik;
        }

        private void NowaFakturaForm_Load(object sender, EventArgs e)
        {
            DaneFirmy DaneFirmy = Program.pobierzDaneFirmy();
            if (DaneFirmy != null)
            {
                BazaDanych.Polaczenie.Fakturies.InsertOnSubmit(faktura);
                faktura.DaneFirmy = DaneFirmy;
                faktura.Uzytkownicy = zalogowanyUzytkownik;
                faktura.Data_sprzedazy = dataSprzedazyDtp.Value;
                faktura.Data_wystawienia = dataWystawieniaDtp.Value;
                faktura.Termin_zaplaty = terminZaplatyDtp.Value;
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane firmy!", "Błąd", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void wybierzKlientaBtn_Click(object sender, EventArgs e)
        {
            ListaKlientówForm ListaKlientówForm = new ListaKlientówForm();
            DialogResult result = ListaKlientówForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                nazwaTb.Text = ListaKlientówForm.wybranyKlient.Nazwa;
                nipTb.Text = ListaKlientówForm.wybranyKlient.Nip;
                ulicaTb.Text = ListaKlientówForm.wybranyKlient.Ulica;
                nrBudynkuTb.Text = ListaKlientówForm.wybranyKlient.Nr_budynku;
                nrMieszkaniaTb.Text = ListaKlientówForm.wybranyKlient.Nr_mieszkania;
                miastoTb.Text = ListaKlientówForm.wybranyKlient.Miasto;
                kodTb.Text = ListaKlientówForm.wybranyKlient.Kod_pocztowy;
                faktura.Klienci = ListaKlientówForm.wybranyKlient;
            }
        }

        private void dodajProduktBtn_Click(object sender, EventArgs e)
        {
            ListaProduktowForm ListaProduktowForm = new ListaProduktowForm();
            DialogResult result = ListaProduktowForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Produkty_sprzedane produktNaFakturze = new Produkty_sprzedane();
                BazaDanych.Polaczenie.Produkty_sprzedanes.InsertOnSubmit(produktNaFakturze);
                produktNaFakturze.Kod_produktu = ListaProduktowForm.produktWybrany.Kod_produktu;
                produktNaFakturze.Ilosc = ListaProduktowForm.iloscProduktu;
                produktNaFakturze.Nazwa_produktu = ListaProduktowForm.produktWybrany.Nazwa;
                produktNaFakturze.Cena_jednostkowa_netto = ListaProduktowForm.produktWybrany.Cena_netto;
                produktNaFakturze.vat = 23;
                produktNaFakturze.Faktury = faktura;
                listaWybranychProduktow.Add(produktNaFakturze);


            }
        }

        private void dataSprzedazyDtp_ValueChanged(object sender, EventArgs e)
        {
            faktura.Data_sprzedazy = dataSprzedazyDtp.Value;
        }

        private void dataWystawieniaDtp_ValueChanged(object sender, EventArgs e)
        {
            faktura.Data_wystawienia = dataWystawieniaDtp.Value;
        }

        private void terminZaplatyDtp_ValueChanged(object sender, EventArgs e)
        {
            faktura.Termin_zaplaty = terminZaplatyDtp.Value;
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {
            //TODO
            //zapis faktury oraz produktów do bazy z jednoczesnym walidowaniem stanu magazynowego
            //odejmowanie produktów z magazynu
            //generowanie numeru faktury
        }

    }
}
