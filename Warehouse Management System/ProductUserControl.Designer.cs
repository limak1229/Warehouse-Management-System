namespace Warehouse_Management_System
{
    partial class ProductUserControl
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
            this.nazwaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.kodTextBox = new MetroFramework.Controls.MetroTextBox();
            this.iloscTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cenaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.usunBtn = new MetroFramework.Controls.MetroButton();
            this.zapiszBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.Location = new System.Drawing.Point(3, 22);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(241, 23);
            this.nazwaTextBox.TabIndex = 0;
            // 
            // kodTextBox
            // 
            this.kodTextBox.Location = new System.Drawing.Point(250, 22);
            this.kodTextBox.Name = "kodTextBox";
            this.kodTextBox.Size = new System.Drawing.Size(75, 23);
            this.kodTextBox.TabIndex = 1;
            // 
            // iloscTextBox
            // 
            this.iloscTextBox.Location = new System.Drawing.Point(400, 22);
            this.iloscTextBox.Name = "iloscTextBox";
            this.iloscTextBox.Size = new System.Drawing.Size(67, 23);
            this.iloscTextBox.TabIndex = 2;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Location = new System.Drawing.Point(331, 22);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(63, 23);
            this.cenaTextBox.TabIndex = 3;
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(538, 22);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(56, 23);
            this.usunBtn.TabIndex = 4;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // zapiszBtn
            // 
            this.zapiszBtn.Location = new System.Drawing.Point(473, 22);
            this.zapiszBtn.Name = "zapiszBtn";
            this.zapiszBtn.Size = new System.Drawing.Size(59, 23);
            this.zapiszBtn.TabIndex = 5;
            this.zapiszBtn.Text = "zapisz";
            this.zapiszBtn.Click += new System.EventHandler(this.zapiszBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Nazwa:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(250, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Kod:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(331, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Cena (zł):";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(400, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Ilość (szt.):";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.zapiszBtn);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(this.iloscTextBox);
            this.Controls.Add(this.kodTextBox);
            this.Controls.Add(this.nazwaTextBox);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(597, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nazwaTextBox;
        private MetroFramework.Controls.MetroTextBox kodTextBox;
        private MetroFramework.Controls.MetroTextBox iloscTextBox;
        private MetroFramework.Controls.MetroTextBox cenaTextBox;
        private MetroFramework.Controls.MetroButton usunBtn;
        private MetroFramework.Controls.MetroButton zapiszBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
