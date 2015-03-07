namespace Warehouse_Management_System
{
    partial class NowyParagonForm
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
            this.txtNowyParagonNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridNowyParagon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNowyParagon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNowyParagonNr
            // 
            this.txtNowyParagonNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNowyParagonNr.Location = new System.Drawing.Point(130, 32);
            this.txtNowyParagonNr.Name = "txtNowyParagonNr";
            this.txtNowyParagonNr.ReadOnly = true;
            this.txtNowyParagonNr.Size = new System.Drawing.Size(182, 22);
            this.txtNowyParagonNr.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nr Paragonu:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(598, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(598, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data wystawienia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data sprzedaży:";
            // 
            // dataGridNowyParagon
            // 
            this.dataGridNowyParagon.AllowUserToAddRows = false;
            this.dataGridNowyParagon.AllowUserToDeleteRows = false;
            this.dataGridNowyParagon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNowyParagon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNowyParagon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNowyParagon.Location = new System.Drawing.Point(37, 161);
            this.dataGridNowyParagon.Name = "dataGridNowyParagon";
            this.dataGridNowyParagon.ReadOnly = true;
            this.dataGridNowyParagon.RowTemplate.Height = 24;
            this.dataGridNowyParagon.Size = new System.Drawing.Size(719, 242);
            this.dataGridNowyParagon.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pozycje:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(535, 445);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 33);
            this.btnAnuluj.TabIndex = 21;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(656, 445);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(100, 33);
            this.btnZapisz.TabIndex = 20;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(37, 445);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(149, 33);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj pozycję:";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // NowyParagonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 490);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridNowyParagon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNowyParagonNr);
            this.Controls.Add(this.label1);
            this.Name = "NowyParagonForm";
            this.Text = "Nowy Paragon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNowyParagon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNowyParagonNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridNowyParagon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnDodaj;
    }
}