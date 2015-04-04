namespace Warehouse_Management_System
{
    partial class ProduktyDoWyboruUserControl
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
            this.nazwaTb = new MetroFramework.Controls.MetroTextBox();
            this.kodTb = new MetroFramework.Controls.MetroTextBox();
            this.cenaTb = new MetroFramework.Controls.MetroTextBox();
            this.iloscTb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // nazwaTb
            // 
            this.nazwaTb.Enabled = false;
            this.nazwaTb.Location = new System.Drawing.Point(3, 3);
            this.nazwaTb.Name = "nazwaTb";
            this.nazwaTb.Size = new System.Drawing.Size(126, 23);
            this.nazwaTb.TabIndex = 0;
            // 
            // kodTb
            // 
            this.kodTb.Enabled = false;
            this.kodTb.Location = new System.Drawing.Point(135, 3);
            this.kodTb.Name = "kodTb";
            this.kodTb.Size = new System.Drawing.Size(75, 23);
            this.kodTb.TabIndex = 0;
            // 
            // cenaTb
            // 
            this.cenaTb.Enabled = false;
            this.cenaTb.Location = new System.Drawing.Point(216, 3);
            this.cenaTb.Name = "cenaTb";
            this.cenaTb.Size = new System.Drawing.Size(56, 23);
            this.cenaTb.TabIndex = 0;
            // 
            // iloscTb
            // 
            this.iloscTb.Enabled = false;
            this.iloscTb.Location = new System.Drawing.Point(278, 3);
            this.iloscTb.Name = "iloscTb";
            this.iloscTb.Size = new System.Drawing.Size(60, 23);
            this.iloscTb.TabIndex = 0;
            // 
            // ProduktyDoWyboruUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.iloscTb);
            this.Controls.Add(this.cenaTb);
            this.Controls.Add(this.kodTb);
            this.Controls.Add(this.nazwaTb);
            this.Name = "ProduktyDoWyboruUserControl";
            this.Size = new System.Drawing.Size(341, 29);
            this.MouseLeave += new System.EventHandler(this.ProduktyDoWyboruUserControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProduktyDoWyboruUserControl_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nazwaTb;
        private MetroFramework.Controls.MetroTextBox kodTb;
        private MetroFramework.Controls.MetroTextBox cenaTb;
        private MetroFramework.Controls.MetroTextBox iloscTb;
    }
}
