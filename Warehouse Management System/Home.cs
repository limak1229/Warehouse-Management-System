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
    }
}
