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
    public partial class ListaProduktowForm : MetroForm
    {
        public Produkty produktWybrany;
        public Int32 iloscProduktu;
        private ProduktyDoWyboruUserControl pdwuc;
        public ListaProduktowForm()
        {
            InitializeComponent();
            
        }

        private void ListaProduktowForm_Load(object sender, EventArgs e)
        {
            Int32 i = 0;
            foreach (Produkty p in BazaDanych.Polaczenie.Produkties)
            {
                ProduktyDoWyboruUserControl PDWUC = new ProduktyDoWyboruUserControl(p);
                PDWUC.Location = new System.Drawing.Point(0, (i++) * (PDWUC.Height));
                PDWUC.Name = "klient" + i.ToString();
                PDWUC.Click += PDWUC_Click;
                this.ProduktyFakturaMetroPanel.Controls.Add(PDWUC);
            }
        }

        void PDWUC_Click(object sender, EventArgs e)
        {
            if (pdwuc != null)
            {
                pdwuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                pdwuc.checkedField = false;
            } 

            pdwuc = (ProduktyDoWyboruUserControl)sender;
            pdwuc.checkedField = true;
            produktWybrany = (Produkty)pdwuc.produkt;
            pdwuc.BackColor = System.Drawing.SystemColors.WindowFrame;
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            Int32 ilosc;
            if(Int32.TryParse(iloscTb.Text, out ilosc))
            {
                if (ilosc != 0 && ilosc <= produktWybrany.Ilosc)
                {
                    iloscProduktu = ilosc;
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
            }
            MessageBox.Show("Wprowadź prawidłową ilość produktu", "Błąd", MessageBoxButtons.OK);
        }
    }
}
