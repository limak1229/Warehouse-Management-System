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
    public partial class KlienciDoFakturyUserControl : UserControl
    {
        public Klienci klient; 
        public KlienciDoFakturyUserControl(Klienci k)
        {
            this.klient = k;
            InitializeComponent();
            nazwaTb.Text = klient.Nazwa;
            nipTb.Text = klient.Nip;
            miastoTb.Text = klient.Miasto;
        }

        private void KlienciDoFakturyUserControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void KlienciDoFakturyUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
        }
    }
}
