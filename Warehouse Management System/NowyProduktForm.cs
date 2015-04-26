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
    public partial class NowyProduktForm : MetroForm
    {
        public NowyProduktForm()
        {
            InitializeComponent();
            this.AcceptButton = ZapiszBtn;
        }

        private void NowyProduktForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["HomeForm"].Activate();
        }

        private void ZapiszBtn_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            Uzytkownicy nowyUzytkownik = new Uzytkownicy();
            Produkty nowyProdukt = new Produkty();

            if (nazwaTb.Text != string.Empty)
            {
                nowyProdukt.Nazwa = nazwaTb.Text;
            }
            else
            {
                error = true;
            }

            if (kodTb.Text != string.Empty)
            {
                nowyProdukt.Kod_produktu = kodTb.Text.ToUpper();
            }
            else
            {
                error = true;
            }

            decimal cena_netto;
            if (decimal.TryParse(cenaTb.Text, out cena_netto) && cena_netto > 0)
            {
                nowyProdukt.Cena_netto = cena_netto;
            }
            else
            {
                error = true;
            }

            Int32 ilosc;
            if (Int32.TryParse(iloscTb.Text, out ilosc) && ilosc > 0)
            {
                nowyProdukt.Ilosc = ilosc;
            }
            else
            {
                error = true;
            }

            Int32 vat;
            if (Int32.TryParse(vatTb.Text, out vat))
            {
                nowyProdukt.Vat = vat;
            }
            else
            {
                error = true;
            }

            if (!error)
            {
                BazaDanych.Polaczenie.Produkties.InsertOnSubmit(nowyProdukt);
                BazaDanych.Polaczenie.SubmitChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wprowadź prawidłowe dane.", "Błąd", MessageBoxButtons.OK);
            }
            
        }

        private void kodTb_KeyUp(object sender, KeyEventArgs e)
        {
            kodTb.Text = kodTb.Text.ToUpper();
            kodTb.Select(kodTb.Text.Length, 0);
        }
    }
}
