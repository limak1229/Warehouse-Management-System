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
    public partial class Browser : Form
    {
        private string p;
        private string fileName;

        public Browser(string fileName, string p)
        {
            InitializeComponent();
            this.p = p;
            this.fileName = fileName;
            Text = "Faktura nr: " + fileName;
            wB.Url = new Uri(p);
        }

    }
}
