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
        public List<Produkty_sprzedane> listaWybranychProduktow = new List<Produkty_sprzedane>();
        public Faktury faktura = new Faktury();
        private Uzytkownicy zalogowanyUzytkownik;
        private HomeForm homeForm;
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

        public NowaFakturaForm(HomeForm homeForm, Faktury f)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            this.faktura = f;
            podgladFaktury();
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
            DaneFirmy DaneFirmy = Program.pobierzDaneFirmy();
            if (DaneFirmy != null)
            {
                numerFakturyTb.Text = faktura.Nr_faktury = pobierzNumerFaktury(DateTime.Now).ToUpper();
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
                produktNaFakturze.Faktury = faktura;
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
            if (faktura.Klienci != null)
            {
                if (faktura.Produkty_sprzedanes.Count > 0)
                {
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

        private string pobierzNumerFaktury(DateTime data)
        {
            Int32 miesiac = data.Month;
            Int32 rok = data.Year;
            Int32 numer = BazaDanych.Polaczenie.Fakturies.Where(f => f.Data_wystawienia.Month == miesiac && f.Data_wystawienia.Year == rok).Count();
            return (numer+1).ToString() + '/' + miesiac.ToString() + '/' + rok.ToString();
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
    }
}
