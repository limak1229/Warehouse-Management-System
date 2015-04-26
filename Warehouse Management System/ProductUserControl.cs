using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class ProductUserControl : UserControl
    {
        private Produkty produkt;
        private HomeForm homeForm;

        public ProductUserControl()
        {
            InitializeComponent();
        }

        public ProductUserControl(HomeForm homeForm, Produkty p)
        {
            this.produkt = p;
            this.homeForm = homeForm;
            InitializeComponent();

            nazwaTextBox.Text = produkt.Nazwa;
            kodTextBox.Text = produkt.Kod_produktu;
            cenaTextBox.Text = produkt.Cena_netto.ToString();
            iloscTextBox.Text = produkt.Ilosc.ToString();
            vatTb.Text = produkt.Vat.ToString();
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz wprowadzić zmiany?", "Potwierdź", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Boolean error = false;

                if (nazwaTextBox.Text != string.Empty)
                {
                    produkt.Nazwa = nazwaTextBox.Text;
                }
                else
                {
                    error = true;
                }

                if (kodTextBox.Text != string.Empty)
                {
                    produkt.Kod_produktu = kodTextBox.Text.ToUpper();
                }
                else
                {
                    error = true;
                }

                decimal cena_netto;
                if (decimal.TryParse(cenaTextBox.Text, out cena_netto) && cena_netto > 0)
                {
                    produkt.Cena_netto = cena_netto;
                }
                else
                {
                    error = true;
                }

                Int32 ilosc;
                if (Int32.TryParse(iloscTextBox.Text, out ilosc) && ilosc > 0)
                {
                    produkt.Ilosc = ilosc;
                }
                else
                {
                    error = true;
                }

                Int32 vat;
                if (Int32.TryParse(vatTb.Text, out vat))
                {
                    produkt.Vat = vat;
                }
                else
                {
                    error = true;
                }

                if (!error)
                {
                    BazaDanych.Polaczenie.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Wprowadź prawidłowe dane.", "Błąd", MessageBoxButtons.OK);
                }

            }
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć?", "Potwierdź", MessageBoxButtons.YesNo);
           
            if (result == DialogResult.Yes)
            {
                BazaDanych.Polaczenie.Produkties.DeleteOnSubmit(produkt);
                BazaDanych.Polaczenie.SubmitChanges();
                homeForm.ProduktyMetroPanel.Controls.Remove(this);
                homeForm.WczytajProdukty();
            }
        }

        private void kodTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            kodTextBox.Text = kodTextBox.Text.ToUpper();
            kodTextBox.Select(kodTextBox.Text.Length, 0);
        }
    }
}
