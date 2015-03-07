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
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnWybierz = new System.Windows.Forms.Button();
            this.dataGridListaKlienci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaKlienci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(13, 382);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(196, 41);
            this.btnAnuluj.TabIndex = 5;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // btnWybierz
            // 
            this.btnWybierz.Location = new System.Drawing.Point(508, 393);
            this.btnWybierz.Margin = new System.Windows.Forms.Padding(4);
            this.btnWybierz.Name = "btnWybierz";
            this.btnWybierz.Size = new System.Drawing.Size(196, 41);
            this.btnWybierz.TabIndex = 4;
            this.btnWybierz.Text = "Wybierz";
            this.btnWybierz.UseVisualStyleBackColor = true;
            // 
            // dataGridListaKlienci
            // 
            this.dataGridListaKlienci.AllowUserToAddRows = false;
            this.dataGridListaKlienci.AllowUserToDeleteRows = false;
            this.dataGridListaKlienci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridListaKlienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListaKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaKlienci.Location = new System.Drawing.Point(13, 13);
            this.dataGridListaKlienci.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridListaKlienci.Name = "dataGridListaKlienci";
            this.dataGridListaKlienci.ReadOnly = true;
            this.dataGridListaKlienci.Size = new System.Drawing.Size(691, 296);
            this.dataGridListaKlienci.TabIndex = 3;
            // 
            // ListaKlientówForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 447);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnWybierz);
            this.Controls.Add(this.dataGridListaKlienci);
            this.Name = "ListaKlientówForm";
            this.Text = "Lista Klientów";
            this.Load += new System.EventHandler(this.ListaKlientówForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaKlienci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnWybierz;
        private System.Windows.Forms.DataGridView dataGridListaKlienci;
    }
}