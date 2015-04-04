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
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = ZalogujButton;
        }

        private void ZalogujButton_Click(object sender, EventArgs e)
        {
            Uzytkownicy zalogowanyUzytkownik = Login(loginTextBox.Text, passwordTextBox.Text);
            if (zalogowanyUzytkownik != null)
            {
                HomeForm HomeForm = new HomeForm(zalogowanyUzytkownik);
                HomeForm.FormClosed += HomeForm_FormClosed;
                HomeForm.Show();
                this.Hide();
                loginInfoLabel.Hide();
            }
            else
            {
                loginInfoLabel.Show();
            }
            
        }

        void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";     
        }

        private Uzytkownicy Login(String login, String password)
        {
            String passwordString = Program.hashPass(password);
            Uzytkownicy user = BazaDanych.Polaczenie.Uzytkownicies.SingleOrDefault(u => u.Login == login && u.Haslo == passwordString);
            return user;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
