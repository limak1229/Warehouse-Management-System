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
            this.SuspendLayout();
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.Location = new System.Drawing.Point(3, 3);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(228, 23);
            this.nazwaTextBox.TabIndex = 0;
            // 
            // kodTextBox
            // 
            this.kodTextBox.Location = new System.Drawing.Point(237, 3);
            this.kodTextBox.Name = "kodTextBox";
            this.kodTextBox.Size = new System.Drawing.Size(88, 23);
            this.kodTextBox.TabIndex = 1;
            // 
            // iloscTextBox
            // 
            this.iloscTextBox.Location = new System.Drawing.Point(400, 3);
            this.iloscTextBox.Name = "iloscTextBox";
            this.iloscTextBox.Size = new System.Drawing.Size(67, 23);
            this.iloscTextBox.TabIndex = 2;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Location = new System.Drawing.Point(331, 3);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(63, 23);
            this.cenaTextBox.TabIndex = 3;
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(538, 3);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(56, 23);
            this.usunBtn.TabIndex = 4;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // zapiszBtn
            // 
            this.zapiszBtn.Location = new System.Drawing.Point(473, 3);
            this.zapiszBtn.Name = "zapiszBtn";
            this.zapiszBtn.Size = new System.Drawing.Size(59, 23);
            this.zapiszBtn.TabIndex = 5;
            this.zapiszBtn.Text = "Zapisz";
            this.zapiszBtn.Click += new System.EventHandler(this.zapiszBtn_Click);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.zapiszBtn);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(this.iloscTextBox);
            this.Controls.Add(this.kodTextBox);
            this.Controls.Add(this.nazwaTextBox);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(597, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nazwaTextBox;
        private MetroFramework.Controls.MetroTextBox kodTextBox;
        private MetroFramework.Controls.MetroTextBox iloscTextBox;
        private MetroFramework.Controls.MetroTextBox cenaTextBox;
        private MetroFramework.Controls.MetroButton usunBtn;
        private MetroFramework.Controls.MetroButton zapiszBtn;
    }
}
