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
            this.SuspendLayout();
            // 
            // ListaKlientowMetroPanel
            // 
            this.ListaKlientowMetroPanel.HorizontalScrollbarBarColor = true;
            this.ListaKlientowMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ListaKlientowMetroPanel.HorizontalScrollbarSize = 10;
            this.ListaKlientowMetroPanel.Location = new System.Drawing.Point(23, 63);
            this.ListaKlientowMetroPanel.Name = "ListaKlientowMetroPanel";
            this.ListaKlientowMetroPanel.Size = new System.Drawing.Size(513, 215);
            this.ListaKlientowMetroPanel.TabIndex = 5;
            this.ListaKlientowMetroPanel.VerticalScrollbarBarColor = true;
            this.ListaKlientowMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ListaKlientowMetroPanel.VerticalScrollbarSize = 10;
            // 
            // ListaKlientówForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(559, 301);
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

        }

        #endregion

        private MetroFramework.Controls.MetroPanel ListaKlientowMetroPanel;

    }
}