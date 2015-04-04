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
    public partial class Nowy_KlientForm : MetroForm
    {
        private Klienci klient;
        private HomeForm homeForm;

        public Nowy_KlientForm(HomeForm hf)
        {
            this.homeForm = hf;
            InitializeComponent();
            zapiszBtn.Hide();
            usunBtn.Hide();
            this.AcceptButton = dodajBtn;
        }

        public Nowy_KlientForm(HomeForm hf, Klienci k)
        {
            this.homeForm = hf;
            this.klient = k;
            InitializeComponent();
            this.Text= "Edytuj klienta";
            dodajBtn.Hide();
            this.AcceptButton = zapiszBtn;
            
            nazwaTb.Text = klient.Nazwa;
            nipTb.Text = klient.Nip;
            ulicaTb.Text = klient.Ulica;
            nrBudynkuTb.Text = klient.Nr_budynku;
            nrMieszkaniaTb.Text = klient.Nr_mieszkania;
            miastoTb.Text = klient.Miasto;
            kodTb.Text = klient.Kod_pocztowy;
        }

        private void Nowy_KlientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["HomeForm"].Activate();
            homeForm.WczytajKlientow();
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć klienta?", "Potwierdź", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                BazaDanych.Polaczenie.Kliencis.DeleteOnSubmit(klient);
                BazaDanych.Polaczenie.SubmitChanges();
            }
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz wprowadzić zmiany?", "Potwierdź", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                klient.Nazwa = nazwaTb.Text;
                klient.Nip = nipTb.Text;
                klient.Ulica = ulicaTb.Text;
                klient.Nr_budynku = nrBudynkuTb.Text;
                klient.Nr_mieszkania = nrMieszkaniaTb.Text;
                klient.Miasto = miastoTb.Text;
                klient.Kod_pocztowy = kodTb.Text;
                BazaDanych.Polaczenie.SubmitChanges();
                this.Close();
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            Klienci k = new Klienci();
            BazaDanych.Polaczenie.Kliencis.InsertOnSubmit(k);
            k.Nazwa = nazwaTb.Text;
            k.Nip = nipTb.Text;
            k.Ulica = ulicaTb.Text;
            k.Nr_budynku = nrBudynkuTb.Text;
            k.Nr_mieszkania = nrMieszkaniaTb.Text;
            k.Miasto = miastoTb.Text;
            k.Kod_pocztowy = kodTb.Text;
            BazaDanych.Polaczenie.SubmitChanges();
            this.Close();
        }
    }
}
