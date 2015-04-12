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
            nowaFakturaForm.listaWybranychProduktow.Remove(p);
            nowaFakturaForm.WczytajProdukty();
        }

        private void vatTb_TextChanged(object sender, EventArgs e)
        {
            Int32 vat;
            if (Int32.TryParse(vatTb.Text, out vat))
            {
                if (vat >= 0)
                {
                    p.vat = vat;
                }
            }
            else
            {
                MessageBox.Show("Wprowadź prawidłową stawkę VAT.", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
