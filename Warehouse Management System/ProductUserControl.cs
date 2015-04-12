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
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz wprowadzić zmiany?", "Potwierdź", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                produkt.Nazwa = nazwaTextBox.Text;
                produkt.Kod_produktu = kodTextBox.Text.ToUpper();
                produkt.Cena_netto = decimal.Parse(cenaTextBox.Text);
                produkt.Ilosc = int.Parse(iloscTextBox.Text);
                BazaDanych.Polaczenie.SubmitChanges();
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
