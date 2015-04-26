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
    public partial class ProduktyNaFakturzeUserControl : UserControl
    {
        private NowaFakturaForm nowaFakturaForm;
        private Produkty_sprzedane p;

        public ProduktyNaFakturzeUserControl(NowaFakturaForm nowaFakturaForm, Produkty_sprzedane p)
        {
            InitializeComponent();
            this.nowaFakturaForm = nowaFakturaForm;
            this.p = p;

            nazwaTb.Text = p.Nazwa_produktu;
            kodTb.Text = p.Kod_produktu;
            sumaCenaNettoTb.Text = (p.Ilosc * p.Cena_jednostkowa_netto).ToString();
            cenaNettoTb.Text = p.Cena_jednostkowa_netto.ToString();
            vatTb.Text = p.vat.ToString();
            iloscTb.Text = p.Ilosc.ToString();
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć?", "Potwierdź", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                nowaFakturaForm.listaWybranychProduktow.Remove(p);
                if (p.Id_produktu_sprzedanego != 0)
                {
                    BazaDanych.Polaczenie.Produkty_sprzedanes.DeleteOnSubmit(p);
                }
                nowaFakturaForm.faktura.Produkty_sprzedanes.Remove(p);
                nowaFakturaForm.WczytajProdukty();
                nowaFakturaForm.SetTotalPriceLabel();
            }
        }

        private void iloscTb_TextChanged(object sender, EventArgs e)
        {
            Int32 ilosc;
            if (Int32.TryParse(iloscTb.Text, out ilosc) && ilosc > 0)
            {
                p.Ilosc = ilosc;
                sumaCenaNettoTb.Text = (p.Cena_jednostkowa_netto * ilosc).ToString();
                nowaFakturaForm.SetTotalPriceLabel();
            }
            else
            {
                MessageBox.Show("Wprowadź prawidłową ilość.", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
