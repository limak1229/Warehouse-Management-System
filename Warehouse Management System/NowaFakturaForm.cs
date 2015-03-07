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

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ListaProduktowForm ListaProduktowForm = new ListaProduktowForm();
            ListaProduktowForm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ListaKlientówForm ListaKlientówForm = new ListaKlientówForm();
            ListaKlientówForm.Show();
        }
    }
}
