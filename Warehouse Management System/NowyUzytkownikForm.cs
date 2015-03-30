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
        }

        private void NowyUzytkownikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["HomeForm"].Activate();
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            Uzytkownicy nowyUzytkownik = new Uzytkownicy();
            BazaDanych.Polaczenie.Uzytkownicies.InsertOnSubmit(nowyUzytkownik);
            Uprawnienia uprawnienia = (typComboBox.SelectedItem as Uprawnienia);
            nowyUzytkownik.Imie = imieTb.Text;
            nowyUzytkownik.Nazwisko = nazwiskoTb.Text;
            nowyUzytkownik.Login = loginTb.Text;
            nowyUzytkownik.Haslo = hashPass(hasloTb.Text);
            nowyUzytkownik.Id_uprawnienia = uprawnienia.Id_uprawnienia;
            BazaDanych.Polaczenie.SubmitChanges();
            this.Close();
        }

        private String hashPass(String password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] md5data = md5.ComputeHash(bytes);
            return Convert.ToBase64String(md5data);
        }
    }
}
