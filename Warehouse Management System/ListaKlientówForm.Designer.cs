namespace Warehouse_Management_System
{
    partial class ListaKlientówForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaKlientowMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.szukajNipTb = new MetroFramework.Controls.MetroTextBox();
            this.szukajNipBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ListaKlientowMetroPanel
            // 
            this.ListaKlientowMetroPanel.HorizontalScrollbarBarColor = true;
            this.ListaKlientowMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ListaKlientowMetroPanel.HorizontalScrollbarSize = 10;
            this.ListaKlientowMetroPanel.Location = new System.Drawing.Point(23, 108);
            this.ListaKlientowMetroPanel.Name = "ListaKlientowMetroPanel";
            this.ListaKlientowMetroPanel.Size = new System.Drawing.Size(513, 220);
            this.ListaKlientowMetroPanel.TabIndex = 5;
            this.ListaKlientowMetroPanel.VerticalScrollbarBarColor = true;
            this.ListaKlientowMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ListaKlientowMetroPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(309, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Kliknij dwukrotnie na dany wiersz aby wybrać klienta";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Wprowadź NIP klienta";
            // 
            // szukajNipTb
            // 
            this.szukajNipTb.Location = new System.Drawing.Point(168, 60);
            this.szukajNipTb.Name = "szukajNipTb";
            this.szukajNipTb.Size = new System.Drawing.Size(75, 23);
            this.szukajNipTb.TabIndex = 8;
            // 
            // szukajNipBtn
            // 
            this.szukajNipBtn.Location = new System.Drawing.Point(249, 60);
            this.szukajNipBtn.Name = "szukajNipBtn";
            this.szukajNipBtn.Size = new System.Drawing.Size(75, 23);
            this.szukajNipBtn.TabIndex = 9;
            this.szukajNipBtn.Text = "Szukaj";
            this.szukajNipBtn.Click += new System.EventHandler(this.szukajNipBtn_Click);
            // 
            // ListaKlientówForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(559, 351);
            this.Controls.Add(this.szukajNipBtn);
            this.Controls.Add(this.szukajNipTb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ListaKlientowMetroPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaKlientówForm";
            this.Resizable = false;
            this.Text = "Lista Klientów";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.ListaKlientówForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel ListaKlientowMetroPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox szukajNipTb;
        private MetroFramework.Controls.MetroButton szukajNipBtn;
    }
}