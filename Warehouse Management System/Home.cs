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
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();
            DataClassesDataContext dbContext = new DataClassesDataContext();
        }
        private void DodajFaktureButton_Click(object sender, EventArgs e)
        {
            NowaFakturaForm NowaFakturaForm = new NowaFakturaForm();
            NowaFakturaForm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NowyProduktForm NowyProduktForm = new NowyProduktForm();
            NowyProduktForm.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Nowy_KlientForm NowyKlientForm = new Nowy_KlientForm();
            NowyKlientForm.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            NowyUzytkownikForm NowyUzytkownikForm = new NowyUzytkownikForm();
            NowyUzytkownikForm.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }
    }
}
