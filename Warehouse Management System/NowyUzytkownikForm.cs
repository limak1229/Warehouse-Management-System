using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class NowyUzytkownikForm : MetroForm
    {
        public NowyUzytkownikForm()
        {
            InitializeComponent();
            typComboBox.DataSource = BazaDanych.Polaczenie.Uprawnienias;
            typComboBox.DisplayMember = "Nazwa";
            this.AcceptButton = zapiszButton;
        }

        private void NowyUzytkownikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["HomeForm"].Activate();
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            Uzytkownicy nowyUzytkownik = new Uzytkownicy();
            Uprawnienia uprawnienia = (typComboBox.SelectedItem as Uprawnienia);
            if (imieTb.Text != string.Empty && nazwiskoTb.Text != string.Empty && loginTb.Text != string.Empty && hasloTb.Text != string.Empty)
            {
                nowyUzytkownik.Imie = imieTb.Text;
                nowyUzytkownik.Nazwisko = nazwiskoTb.Text;
                nowyUzytkownik.Login = loginTb.Text;
                nowyUzytkownik.Haslo = Program.hashPass(hasloTb.Text);
                nowyUzytkownik.Id_uprawnienia = uprawnienia.Id_uprawnienia;
                BazaDanych.Polaczenie.Uzytkownicies.InsertOnSubmit(nowyUzytkownik);
                BazaDanych.Polaczenie.SubmitChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wprowadź prawidłowe dane.", "Błąd", MessageBoxButtons.OK);
            } 
        }

        private void AnulujBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
