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
        }

        private void NowyProduktForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["HomeForm"].Activate();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Uzytkownicy nowyUzytkownik = new Uzytkownicy();
            Produkty nowyProdukt = new Produkty();

            BazaDanych.Polaczenie.Produkties.InsertOnSubmit(nowyProdukt);
            nowyProdukt.Nazwa = nazwaTb.Text;
            nowyProdukt.Kod_produktu = kodTb.Text;
            nowyProdukt.Cena_netto = decimal.Parse(cenaTb.Text);
            nowyProdukt.Ilosc = int.Parse(iloscTb.Text);
            BazaDanych.Polaczenie.SubmitChanges();
            this.Close();
        }
    }
}
