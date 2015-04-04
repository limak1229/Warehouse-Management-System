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
    public partial class ProduktyDoWyboruUserControl : UserControl
    {
        public Produkty produkt;
        public bool checkedField;

        public ProduktyDoWyboruUserControl()
        {
            InitializeComponent();
        }

        public ProduktyDoWyboruUserControl(Produkty p)
        {
            this.produkt = p;
            InitializeComponent();
            nazwaTb.Text = produkt.Nazwa;
            kodTb.Text = produkt.Kod_produktu;
            cenaTb.Text = produkt.Cena_netto.ToString();
            iloscTb.Text = produkt.Ilosc.ToString();
        }

        private void ProduktyDoWyboruUserControl_MouseLeave(object sender, EventArgs e)
        {
            if (!checkedField)
            {
                this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            }
        }

        private void ProduktyDoWyboruUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
        }
    }
}
