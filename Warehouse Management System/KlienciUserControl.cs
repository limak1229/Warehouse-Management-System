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
    public partial class KlienciUserControl : UserControl
    {
        private Klienci klient;
        private HomeForm homeForm;

        public KlienciUserControl(HomeForm f, Klienci k)
        {
            this.klient = k;
            this.homeForm = f;
            InitializeComponent();
            nazwaTb.Text = klient.Nazwa;
            nipTb.Text = klient.Nip;
            miastoTb.Text = klient.Miasto;
        }

        public KlienciUserControl()
        {
            InitializeComponent();
        }

        private void usunBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć?", "Potwierdź", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                BazaDanych.Polaczenie.Kliencis.DeleteOnSubmit(klient);
                BazaDanych.Polaczenie.SubmitChanges();
                homeForm.KlienciMetroPanel.Controls.Remove(this);
                homeForm.WczytajKlientow();
            }
        }

        private void edytujBtn_Click(object sender, EventArgs e)
        {
            Nowy_KlientForm kf = new Nowy_KlientForm(this.homeForm, klient);
            kf.Show();
        }
    }
}
