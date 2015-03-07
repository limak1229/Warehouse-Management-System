namespace Warehouse_Management_System
{
    partial class NowyUzytkownikForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypSelect = new System.Windows.Forms.ComboBox();
            this.HasloTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Typ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // TypSelect
            // 
            this.TypSelect.FormattingEnabled = true;
            this.TypSelect.Items.AddRange(new object[] {
            "Pracownik",
            "Kierownik",
            "Szef"});
            this.TypSelect.Location = new System.Drawing.Point(71, 110);
            this.TypSelect.Name = "TypSelect";
            this.TypSelect.Size = new System.Drawing.Size(120, 21);
            this.TypSelect.TabIndex = 10;
            // 
            // HasloTextBox
            // 
            this.HasloTextBox.Location = new System.Drawing.Point(71, 84);
            this.HasloTextBox.Name = "HasloTextBox";
            this.HasloTextBox.Size = new System.Drawing.Size(120, 20);
            this.HasloTextBox.TabIndex = 9;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(71, 58);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(120, 20);
            this.LoginTextBox.TabIndex = 8;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(35, 137);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 24);
            this.btnAnuluj.TabIndex = 12;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(116, 137);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 24);
            this.btnZapisz.TabIndex = 11;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Imie:";
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(71, 6);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(120, 20);
            this.ImieTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nazwisko:";
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Location = new System.Drawing.Point(71, 32);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(120, 20);
            this.NazwiskoTextBox.TabIndex = 16;
            // 
            // NowyUzytkownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 168);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.TypSelect);
            this.Controls.Add(this.HasloTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NowyUzytkownikForm";
            this.Text = "Nowy Uzytkownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypSelect;
        private System.Windows.Forms.TextBox HasloTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
    }
}