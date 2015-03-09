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
using Warehouse_Management_System;

namespace Warehouse_Management_System
{
    public partial class HomeForm : MetroForm
    {
        bool logout = false;
        public HomeForm()
        {
            InitializeComponent();
            DataClassesDataContext dbContext = new DataClassesDataContext();
        }
        private void DodajFaktureBtn_Click(object sender, EventArgs e)
        {
            NowaFakturaForm NowaFakturaForm = new NowaFakturaForm();
            NowaFakturaForm.Show();
        }

        private void DodajProduktBtn_Click(object sender, EventArgs e)
        {
            NowyProduktForm NowyProduktForm = new NowyProduktForm();
            NowyProduktForm.Show();
        }

        private void DodajKlientaBtn_Click(object sender, EventArgs e)
        {
            Nowy_KlientForm NowyKlientForm = new Nowy_KlientForm();
            NowyKlientForm.Show();
        }

        private void DodajUzytkownikaBtn_Click(object sender, EventArgs e)
        {
            NowyUzytkownikForm NowyUzytkownikForm = new NowyUzytkownikForm();
            NowyUzytkownikForm.Show();
        }

        private void WylogujBtn_Click(object sender, EventArgs e)
        {
            this.logout = true;
            this.Close();
            Form LF = Application.OpenForms["LoginForm"];
            LF.Show();
            LF.Activate();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.logout)
            {
                Application.Exit();
            }
        }
    }
}
