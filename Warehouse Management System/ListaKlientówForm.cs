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
    public partial class ListaKlientówForm : MetroForm
    {
        public Klienci wybranyKlient;
        public ListaKlientówForm()
        {
            InitializeComponent();
        }

        private void ListaKlientówForm_Load(object sender, EventArgs e)
        {
            Int32 i = 0;
            foreach (Klienci k in BazaDanych.Polaczenie.Kliencis)
            {
                KlienciDoFakturyUserControl KDFUC = new KlienciDoFakturyUserControl(k);
                KDFUC.DoubleClick += KDFUC_DoubleClick;
                KDFUC.Location = new System.Drawing.Point(0, (i++) * (KDFUC.Height));
                KDFUC.Name = "klient" + i.ToString();
                this.ListaKlientowMetroPanel.Controls.Add(KDFUC);
            }
        }

        void KDFUC_DoubleClick(object sender, EventArgs e)
        {
            wybranyKlient = (sender as KlienciDoFakturyUserControl).klient;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
