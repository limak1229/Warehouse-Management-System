namespace Warehouse_Management_System
{
    partial class ListaProduktowForm
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
            this.dataGridProduktyLista = new System.Windows.Forms.DataGridView();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduktyLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProduktyLista
            // 
            this.dataGridProduktyLista.AllowUserToAddRows = false;
            this.dataGridProduktyLista.AllowUserToDeleteRows = false;
            this.dataGridProduktyLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProduktyLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduktyLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduktyLista.Location = new System.Drawing.Point(11, 11);
            this.dataGridProduktyLista.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridProduktyLista.Name = "dataGridProduktyLista";
            this.dataGridProduktyLista.ReadOnly = true;
            this.dataGridProduktyLista.RowTemplate.Height = 24;
            this.dataGridProduktyLista.Size = new System.Drawing.Size(325, 368);
            this.dataGridProduktyLista.TabIndex = 1;
            // 
            // txtIlosc
            // 
            this.txtIlosc.Location = new System.Drawing.Point(125, 388);
            this.txtIlosc.Margin = new System.Windows.Forms.Padding(2);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(96, 20);
            this.txtIlosc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ilość:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(225, 383);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(111, 28);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // ListaProduktowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 422);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridProduktyLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaProduktowForm";
            this.Text = "Lista Produktow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduktyLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProduktyLista;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
    }
}