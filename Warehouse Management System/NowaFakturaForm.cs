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
    public partial class NowaFakturaForm : MetroForm
    {
        public NowaFakturaForm()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ListaProduktowForm ListaProduktowForm = new ListaProduktowForm();
            ListaProduktowForm.ShowDialog();
        }

        private void wybierzKlientaBtn_Click(object sender, EventArgs e)
        {
            ListaKlientówForm ListaKlientówForm = new ListaKlientówForm();
            DialogResult result = ListaKlientówForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                nazwaTb.Text = ListaKlientówForm.wybranyKlient.Nazwa;
                nipTb.Text = ListaKlientówForm.wybranyKlient.Nip;
                ulicaTb.Text = ListaKlientówForm.wybranyKlient.Ulica;
                nrBudynkuTb.Text = ListaKlientówForm.wybranyKlient.Nr_budynku;
                nrMieszkaniaTb.Text = ListaKlientówForm.wybranyKlient.Nr_mieszkania;
                miastoTb.Text = ListaKlientówForm.wybranyKlient.Miasto;
                kodTb.Text = ListaKlientówForm.wybranyKlient.Kod_pocztowy;
            }
        }
    }
}
