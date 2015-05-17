using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class NowaFakturaForm : MetroForm
    {
        public List<Produkty_sprzedane> listaWybranychProduktow = new List<Produkty_sprzedane>();
        public List<Produkty_sprzedane> listaStarychProduktow = new List<Produkty_sprzedane>();
        public List<Produkty_sprzedane> listaDoKopiowania = new List<Produkty_sprzedane>();
        public Faktury faktura;
        public Faktury kfaktura;
        private Uzytkownicy zalogowanyUzytkownik;
        private HomeForm homeForm;
        private DaneFirmy DaneFirmy;
        bool error = false;
        public bool edit = false;

        private void NowaFakturaForm_Load(object sender, EventArgs e)
        {
            if (error)
            {
                Close();
            }
        }

        public NowaFakturaForm(Uzytkownicy zalogowanyUzytkownik)
        {
            InitializeComponent();
            this.zalogowanyUzytkownik = zalogowanyUzytkownik;
            NowaFaktura();
        }

        public NowaFakturaForm(Uzytkownicy zalogowanyUzytkownik, HomeForm homeForm, Faktury f)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            this.faktura = f;
            this.zalogowanyUzytkownik = zalogowanyUzytkownik;
            podgladFaktury();
            kopiaProduktow();
        }

        private void kopiaProduktow()
        {
            foreach (Produkty_sprzedane p in listaWybranychProduktow)
            {
                Produkty_sprzedane p2 = new Produkty_sprzedane();
                p2.Korekta = 0;
                p2.Cena_jednostkowa_netto = p.Cena_jednostkowa_netto;
                p2.Ilosc = p.Ilosc;
                p2.Kod_produktu = p.Kod_produktu;
                p2.Nazwa_produktu = p.Nazwa_produktu;
                p2.vat = p.vat;
                listaStarychProduktow.Add(p2);
                BazaDanych.Polaczenie.Produkty_sprzedanes.DeleteOnSubmit(p);
            }

            foreach (Produkty_sprzedane p in listaWybranychProduktow)
            {
                Produkty_sprzedane p2 = new Produkty_sprzedane();
                p2.Korekta = 0;
                p2.Cena_jednostkowa_netto = p.Cena_jednostkowa_netto;
                p2.Ilosc = p.Ilosc;
                p2.Kod_produktu = p.Kod_produktu;
                p2.Nazwa_produktu = p.Nazwa_produktu;
                p2.vat = p.vat;
                listaDoKopiowania.Add(p2);
            }
        }

        private void podgladFaktury()
        {
            edit = true;
            wybierzKlientaBtn.Visible = false;
            listaWybranychProduktow = faktura.Produkty_sprzedanes.ToList();
            Text = "Korekta faktury";

            numerFakturyTb.Text = faktura.Nr_faktury;
            nazwaTb.Text = faktura.Klienci.Nazwa;
            nipTb.Text = faktura.Klienci.Nip;
            ulicaTb.Text = faktura.Klienci.Ulica;
            nrBudynkuTb.Text = faktura.Klienci.Nr_budynku;
            nrMieszkaniaTb.Text = faktura.Klienci.Nr_mieszkania;
            miastoTb.Text = faktura.Klienci.Miasto;
            kodTb.Text = faktura.Klienci.Kod_pocztowy;

            dataSprzedazyDtp.Value = faktura.Data_sprzedazy;
            terminZaplatyDtp.Value = faktura.Termin_zaplaty;

            WczytajProdukty();

        }

        private void NowaFaktura()
        {
            DaneFirmy = Program.pobierzDaneFirmy();
            if (DaneFirmy != null)
            {
                faktura = new Faktury();
                numerFakturyTb.Text = faktura.Nr_faktury = pobierzNumerFaktury(DateTime.Now).ToUpper();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane firmy!", "Błąd", MessageBoxButtons.OK);
                error = true;
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
                produktNaFakturze.Kod_produktu = ListaProduktowForm.produktWybrany.Kod_produktu;
                produktNaFakturze.Ilosc = ListaProduktowForm.iloscProduktu;
                ListaProduktowForm.produktWybrany.Ilosc -= produktNaFakturze.Ilosc;
                produktNaFakturze.Nazwa_produktu = ListaProduktowForm.produktWybrany.Nazwa;
                produktNaFakturze.Cena_jednostkowa_netto = ListaProduktowForm.produktWybrany.Cena_netto;
                produktNaFakturze.vat = ListaProduktowForm.produktWybrany.Vat;
                if (edit)
                {
                    produktNaFakturze.Faktury = kfaktura;
                }
                else
                {
                    produktNaFakturze.Faktury = faktura;
                }
                listaWybranychProduktow.Add(produktNaFakturze);
               
                WczytajProdukty();
            }
        }

        private void dataSprzedazyDtp_ValueChanged(object sender, EventArgs e)
        {
            faktura.Data_sprzedazy = dataSprzedazyDtp.Value;
        }

        private void dataWystawieniaDtp_ValueChanged(object sender, EventArgs e)
        {
            faktura.Data_wystawienia = dataWystawieniaDtp.Value;
            pobierzNumerFaktury(faktura.Data_sprzedazy);
        }

        private void terminZaplatyDtp_ValueChanged(object sender, EventArgs e)
        {
            faktura.Termin_zaplaty = terminZaplatyDtp.Value;
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {
            if(!edit)
            {
                if (faktura.Klienci != null)
                {
                    if (faktura.Produkty_sprzedanes.Count > 0)
                    {
                        faktura.Data_sprzedazy = dataSprzedazyDtp.Value;
                        faktura.Termin_zaplaty = terminZaplatyDtp.Value;
                        faktura.DaneFirmy = DaneFirmy;
                        faktura.Uzytkownicy = zalogowanyUzytkownik;
                        faktura.Data_wystawienia = dataWystawieniaDtp.Value;
                        BazaDanych.Polaczenie.Fakturies.InsertOnSubmit(faktura);

                        foreach (var p in listaWybranychProduktow.Where(p => p.Id_produktu_sprzedanego == 0))
                        {
                            BazaDanych.Polaczenie.Produkty_sprzedanes.InsertOnSubmit(p);
                        }

                        BazaDanych.Polaczenie.SubmitChanges();
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Proszę wybrać produkty.", "Błąd", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Proszę wybrać klienta.", "Błąd", MessageBoxButtons.OK);
                }  
            }
            else
            {
                if (listaWybranychProduktow.Count > 0)
                {
                    Korekta();
                    BazaDanych.Polaczenie.Fakturies.InsertOnSubmit(kfaktura);
                    BazaDanych.Polaczenie.SubmitChanges();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Proszę wybrać produkty.", "Błąd", MessageBoxButtons.OK);
                }
                
            }
            
        }

        private string pobierzNumerFaktury(DateTime data)
        {
            Int32 miesiac = data.Month;
            Int32 rok = data.Year;
            Int32 numer = BazaDanych.Polaczenie.Fakturies.Where(f => f.Data_wystawienia.Month == miesiac && f.Data_wystawienia.Year == rok).Count();
            return (numer+1).ToString() + '-' + miesiac.ToString() + '-' + rok.ToString();
        }

        public void WczytajProdukty()
        {
            var ListaElementow = this.Controls.Find("produktyNaFakturzeMetroPanel", true).First().Controls.OfType<ProduktyNaFakturzeUserControl>().ToList();
            foreach (var el in ListaElementow)
            {
                produktyNaFakturzeMetroPanel.Controls.Remove(el);
            }
            Int32 i = 0;
            foreach (Produkty_sprzedane p in listaWybranychProduktow)
            {
                ProduktyNaFakturzeUserControl PNFUC = new ProduktyNaFakturzeUserControl(this, p);
                PNFUC.Location = new System.Drawing.Point(0, (i++) * (PNFUC.Height));
                PNFUC.Name = "produktSprzedany" + i.ToString();
                produktyNaFakturzeMetroPanel.Controls.Add(PNFUC);
            }

            if (listaWybranychProduktow.Count() > 0)
            {
                l1.Visible = l2.Visible = l3.Visible = l4.Visible = l5.Visible = l6.Visible = true;
            }
            else
            {
                l1.Visible = l2.Visible = l3.Visible = l4.Visible = l5.Visible = l6.Visible = false;
            }
        }

        private void NowaFakturaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (edit)
            {
                homeForm.Activate();
            }
        }
        public void SetTotalPriceLabel()
        {
            decimal totalNetto = 0;
            decimal totalBrutto = 0;
            foreach (var lwp in listaWybranychProduktow)
            {
                totalNetto += lwp.Cena_jednostkowa_netto * lwp.Ilosc;
                totalBrutto += (lwp.Cena_jednostkowa_netto + (lwp.Cena_jednostkowa_netto * lwp.vat / 100)) * lwp.Ilosc;
            }
            sumaNettoLbl.Text = totalNetto.ToString() + " zł.";
            sumaBruttoLbl.Text = totalBrutto.ToString() + " zł.";
        }

        private void Korekta()
        {
            kfaktura = new Faktury();
            kfaktura.Data_korekty = DateTime.Now;
            kfaktura.DaneFirmy = faktura.DaneFirmy;
            kfaktura.Data_sprzedazy = faktura.Data_sprzedazy;
            kfaktura.Data_wystawienia = faktura.Data_wystawienia;
            kfaktura.Klienci = faktura.Klienci;
            kfaktura.Nr_faktury = faktura.Nr_faktury + "-K";
            kfaktura.Termin_zaplaty = faktura.Termin_zaplaty;
            kfaktura.Uzytkownicy = zalogowanyUzytkownik;
            kfaktura.Poprzednia_faktura_id = faktura.Id_faktury;

            foreach (var p in listaWybranychProduktow)
            {
                Produkty_sprzedane p2 = new Produkty_sprzedane();
                p2.Faktury = kfaktura;
                p2.Korekta = 1;
                p2.Cena_jednostkowa_netto = p.Cena_jednostkowa_netto;
                p2.Ilosc = p.Ilosc;
                p2.Kod_produktu = p.Kod_produktu;
                p2.Nazwa_produktu = p.Nazwa_produktu;
                p2.vat = p.vat;
                BazaDanych.Polaczenie.Produkty_sprzedanes.InsertOnSubmit(p2);
            }

            foreach (var p in listaStarychProduktow)
            {
                p.Faktury = kfaktura;
                BazaDanych.Polaczenie.Produkty_sprzedanes.InsertOnSubmit(p);
            }

            foreach (var p in listaDoKopiowania)
            {
                p.Faktury = faktura;
                BazaDanych.Polaczenie.Produkty_sprzedanes.InsertOnSubmit(p);
            }
        }
    }
}
