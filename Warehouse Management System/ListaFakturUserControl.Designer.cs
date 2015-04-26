namespace Warehouse_Management_System
{
    partial class ListaFakturUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numerFakturyTb = new MetroFramework.Controls.MetroTextBox();
            this.nazwaFirmyTb = new MetroFramework.Controls.MetroTextBox();
            this.nipTb = new MetroFramework.Controls.MetroTextBox();
            this.edytujFaktureBtn = new MetroFramework.Controls.MetroButton();
            this.dataWystawienia = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // numerFakturyTb
            // 
            this.numerFakturyTb.Enabled = false;
            this.numerFakturyTb.Location = new System.Drawing.Point(3, 3);
            this.numerFakturyTb.Name = "numerFakturyTb";
            this.numerFakturyTb.Size = new System.Drawing.Size(89, 23);
            this.numerFakturyTb.TabIndex = 0;
            this.numerFakturyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nazwaFirmyTb
            // 
            this.nazwaFirmyTb.Enabled = false;
            this.nazwaFirmyTb.Location = new System.Drawing.Point(98, 3);
            this.nazwaFirmyTb.Name = "nazwaFirmyTb";
            this.nazwaFirmyTb.Size = new System.Drawing.Size(164, 23);
            this.nazwaFirmyTb.TabIndex = 0;
            // 
            // nipTb
            // 
            this.nipTb.Enabled = false;
            this.nipTb.Location = new System.Drawing.Point(268, 3);
            this.nipTb.Name = "nipTb";
            this.nipTb.Size = new System.Drawing.Size(75, 23);
            this.nipTb.TabIndex = 0;
            this.nipTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edytujFaktureBtn
            // 
            this.edytujFaktureBtn.Location = new System.Drawing.Point(482, 3);
            this.edytujFaktureBtn.Name = "edytujFaktureBtn";
            this.edytujFaktureBtn.Size = new System.Drawing.Size(110, 23);
            this.edytujFaktureBtn.TabIndex = 2;
            this.edytujFaktureBtn.Text = "Korekta";
            this.edytujFaktureBtn.Click += new System.EventHandler(this.edytujFaktureBtn_Click);
            // 
            // dataWystawienia
            // 
            this.dataWystawienia.Enabled = false;
            this.dataWystawienia.Location = new System.Drawing.Point(349, 4);
            this.dataWystawienia.Name = "dataWystawienia";
            this.dataWystawienia.Size = new System.Drawing.Size(127, 20);
            this.dataWystawienia.TabIndex = 3;
            // 
            // ListaFakturUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataWystawienia);
            this.Controls.Add(this.edytujFaktureBtn);
            this.Controls.Add(this.nipTb);
            this.Controls.Add(this.nazwaFirmyTb);
            this.Controls.Add(this.numerFakturyTb);
            this.Name = "ListaFakturUserControl";
            this.Size = new System.Drawing.Size(595, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox numerFakturyTb;
        private MetroFramework.Controls.MetroTextBox nazwaFirmyTb;
        private MetroFramework.Controls.MetroTextBox nipTb;
        private MetroFramework.Controls.MetroButton edytujFaktureBtn;
        private System.Windows.Forms.DateTimePicker dataWystawienia;
    }
}
