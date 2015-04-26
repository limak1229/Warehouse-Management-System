using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Warehouse_Management_System
{
    public partial class UzytkownicyUserControl : UserControl
    {
        Uzytkownicy uzytkownik;
        HomeForm homeForm;

        public UzytkownicyUserControl()
        {
            InitializeComponent();
        }

        public UzytkownicyUserControl(HomeForm hf, Uzytkownicy u)
        {
            this.uzytkownik = u;
            this.homeForm = hf;
            InitializeComponent();
            uprawnieniaCb.DataSource = BazaDanych.Polaczenie.Uprawnienias;
            uprawnieniaCb.DisplayMember = "Nazwa";
            uprawnieniaCb.SelectedItem = uzytkownik.Uprawnienia;
            nazwiskoTb.Text = uzytkownik.Nazwisko;
            imieTb.Text = uzytkownik.Imie;
            loginTb.Text = uzytkownik.Login;
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz wprowadzić zmiany?", "Potwierdź", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (imieTb.Text != string.Empty && nazwiskoTb.Text != string.Empty && loginTb.Text != string.Empty)
                {
                    Uprawnienia uprawnienie = (uprawnieniaCb.SelectedItem as Uprawnienia);
                    uzytkownik.Imie = imieTb.Text;
                    uzytkownik.Nazwisko = nazwiskoTb.Text;
                    uzytkownik.Login = loginTb.Text;
                    uzytkownik.Uprawnienia = uprawnienie;
                    String HP = Program.hashPass(hasloTb.Text);
                    if (uzytkownik.Haslo != String.Empty && uzytkownik.Haslo != HP)
                    {
                        uzytkownik.Haslo = HP;
                    }
                    BazaDanych.Polaczenie.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Wprowadź prawidłowe dane.", "Błąd", MessageBoxButtons.OK);
                } 
            }
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć?", "Potwierdź", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                BazaDanych.Polaczenie.Uzytkownicies.DeleteOnSubmit(uzytkownik);
                BazaDanych.Polaczenie.SubmitChanges();
                homeForm.UzytkownicyMetroPanel.Controls.Remove(this);
                homeForm.WczytajUzytkownikow();
            }
        }
    }
}
