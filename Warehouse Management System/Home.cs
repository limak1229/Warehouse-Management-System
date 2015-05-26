using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
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
            if (zalogowanyUzytkownik.Uprawnienia.Nazwa == "Administrator")
            {
                WczytajProdukty();
                WczytajDaneFirmy();
                WczytajKlientow();
                WczytajFaktury();
                WczytajUzytkownikow();
            } 
            else if (zalogowanyUzytkownik.Uprawnienia.Nazwa == "Magazynier")
            {
                this.MetroTabControl.Controls.Remove(this.FakturyTabPage);
                this.MetroTabControl.Controls.Remove(this.KlienciTabPage);
                this.MetroTabControl.Controls.Remove(this.UzytkownicyTabPage);
                this.MetroTabControl.Controls.Remove(this.UstawieniaTabPage);
                WczytajProdukty();
            }
            else if (zalogowanyUzytkownik.Uprawnienia.Nazwa == "Kierownik")
            {
                this.MetroTabControl.Controls.Remove(this.ProduktyTabPage);
                this.MetroTabControl.Controls.Remove(this.UzytkownicyTabPage);
                this.MetroTabControl.Controls.Remove(this.UstawieniaTabPage);
                WczytajKlientow();
                WczytajFaktury();
            }
            
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
            iloscUzytkownikowLabel.Text = "Liczba użytkowników: " + i.ToString();
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
            iloscProduktowLabel.Text = "Liczba produktów: " + i.ToString();
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
            iloscKlientowLabel.Text = "Liczba klientów: " + i.ToString();
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
                ListaFakturUserControl LFUC = new ListaFakturUserControl(zalogowanyUzytkownik, this, f);
                LFUC.Location = new System.Drawing.Point(0, (i++) * (LFUC.Height));
                LFUC.Name = "faktura" + i.ToString();
                this.FakturyMetroPanel.Controls.Add(LFUC);
            }
            iloscFakturLabel.Text = "Liczba faktur: " + i.ToString();
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

        private void importujProduktyBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.DefaultExt = "xml";
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.ShowDialog();

            if (ofd.FileName != string.Empty)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ofd.FileName);

                foreach (XmlNode produkt in doc.DocumentElement.ChildNodes)
                {
                    if (produkt.HasChildNodes)
                    {
                        XmlNode nazwaNode = produkt.SelectSingleNode("nazwa");
                        XmlNode cenaNode = produkt.SelectSingleNode("cena");
                        XmlNode iloscNode = produkt.SelectSingleNode("ilosc");
                        XmlNode vatNode = produkt.SelectSingleNode("vat");
                        XmlNode kodNode = produkt.SelectSingleNode("kod");
                        if (nazwaNode != null && cenaNode != null && iloscNode != null && vatNode != null && kodNode != null)
                        {
                            Produkty p = new Produkty();
                            p.Nazwa = nazwaNode.InnerText;
                            p.Cena_netto= decimal.Parse(cenaNode.InnerText);
                            p.Ilosc = Int32.Parse(iloscNode.InnerText);
                            p.Vat = Int32.Parse(vatNode.InnerText);
                            p.Kod_produktu = kodNode.InnerText;

                            Produkty produktAktualizacja = BazaDanych.Polaczenie.Produkties.Where(p2 => p2.Kod_produktu == p.Kod_produktu).FirstOrDefault();
                            
                            if (produktAktualizacja != null)
                            {
                                produktAktualizacja.Ilosc = p.Ilosc;
                                produktAktualizacja.Nazwa = p.Nazwa;
                                produktAktualizacja.Cena_netto = p.Cena_netto;
                                produktAktualizacja.Vat = p.Vat;
                            }
                            else
                            {
                                BazaDanych.Polaczenie.Produkties.InsertOnSubmit(p);
                            }
                            BazaDanych.Polaczenie.SubmitChanges();
                        }
                    }
                }
                WczytajProdukty();
            }
        }

        private void importujKlientowBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.DefaultExt = "xml";
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.ShowDialog();

            if (ofd.FileName != string.Empty)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ofd.FileName);

                foreach (XmlNode klient in doc.DocumentElement.ChildNodes)
                {
                    if (klient.HasChildNodes)
                    {
                        XmlNode nazwaNode = klient.SelectSingleNode("nazwa");
                        XmlNode ulicaNode = klient.SelectSingleNode("ulica");
                        XmlNode nrBudynkuNode = klient.SelectSingleNode("nrBudynku");
                        XmlNode nrMieszkaniaNode = klient.SelectSingleNode("nrMieszkania");
                        XmlNode miastoNode = klient.SelectSingleNode("miasto");
                        XmlNode nipNode = klient.SelectSingleNode("nip");
                        XmlNode telefonNode = klient.SelectSingleNode("telefon");
                        XmlNode kodNode = klient.SelectSingleNode("kod");

                        if (nazwaNode != null && ulicaNode != null && nrBudynkuNode != null && nrMieszkaniaNode != null && miastoNode != null && nipNode != null && telefonNode != null && kodNode != null)
                        {
                            Klienci k = new Klienci();
                            k.Kod_pocztowy = kodNode.InnerText;
                            k.Ulica = ulicaNode.InnerText;
                            k.Miasto = miastoNode.InnerText;
                            k.Nazwa = nazwaNode.InnerText;
                            k.Nip = nipNode.InnerText;
                            k.Nr_budynku = nrBudynkuNode.InnerText;
                            k.Nr_mieszkania = nrMieszkaniaNode.InnerText;
                            k.Telefon = telefonNode.InnerText;

                            Klienci klientAktualizacja = BazaDanych.Polaczenie.Kliencis.Where(k2 => k2.Nip == k.Nip).FirstOrDefault();

                            if (klientAktualizacja != null)
                            {
                                klientAktualizacja.Kod_pocztowy = k.Kod_pocztowy;
                                klientAktualizacja.Miasto = k.Miasto;
                                klientAktualizacja.Ulica = k.Ulica;
                                klientAktualizacja.Nazwa = k.Nazwa;
                                klientAktualizacja.Nr_budynku = k.Nr_budynku;
                                klientAktualizacja.Nr_mieszkania = k.Nr_mieszkania;
                                klientAktualizacja.Telefon = k.Telefon;
                            }
                            else
                            {
                                BazaDanych.Polaczenie.Kliencis.InsertOnSubmit(k);
                            }
                            BazaDanych.Polaczenie.SubmitChanges();
                        }
                    }
                }
                WczytajKlientow();
            }
        }

        private void zapiszHasloBtn_Click(object sender, EventArgs e)
        {
            if (pass.Text.Length > 0 && pass2.Text.Length > 0 && pass2.Text == pass.Text)
            {
                zalogowanyUzytkownik.Haslo = Program.hashPass(pass.Text);
                BazaDanych.Polaczenie.SubmitChanges();
                MessageBox.Show("Hasło zostało zmienione.", "Zmiana hasła", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hasła nie mogą się od siebie róznić.", "Nieprawidłowe hasło", MessageBoxButtons.OK);
            }
        }
    }
}
