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
    public partial class ListaFakturUserControl : UserControl
    {
        private HomeForm homeForm;
        private Faktury f;

        public ListaFakturUserControl()
        {
            InitializeComponent();
        }

        public ListaFakturUserControl(HomeForm homeForm, Faktury f)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            this.f = f;
            wczytajDane();
        }

        private void wczytajDane()
        {
            numerFakturyTb.Text = f.Nr_faktury.ToString();
            nazwaFirmyTb.Text = f.Klienci.Nazwa;
            nipTb.Text = f.Klienci.Nip;
            dataWystawienia.Value = f.Data_wystawienia;
        }

        private void usunFaktureBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć?", "Potwierdź", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (Produkty_sprzedane p in f.Produkty_sprzedanes)
                {
                    BazaDanych.Polaczenie.Produkty_sprzedanes.DeleteOnSubmit(p);
                }
                BazaDanych.Polaczenie.Fakturies.DeleteOnSubmit(f);
                BazaDanych.Polaczenie.SubmitChanges();
                homeForm.WczytajFaktury();
            }
        }

        private void edytujFaktureBtn_Click(object sender, EventArgs e)
        {
            NowaFakturaForm nff = new NowaFakturaForm(homeForm, f);
            nff.Show();
        }
    }
}
