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
            this.comboUzytkownicyNowy = new System.Windows.Forms.ComboBox();
            this.txtUzytkownicyNowyHaslo = new System.Windows.Forms.TextBox();
            this.txtUzytkownicyNowyLogin = new System.Windows.Forms.TextBox();
            this.btnUzytkownicyAnuluj = new System.Windows.Forms.Button();
            this.btnUzytkownicyZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Typ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // comboUzytkownicyNowy
            // 
            this.comboUzytkownicyNowy.FormattingEnabled = true;
            this.comboUzytkownicyNowy.Items.AddRange(new object[] {
            "Pracownik",
            "Kierownik",
            "Szef"});
            this.comboUzytkownicyNowy.Location = new System.Drawing.Point(161, 136);
            this.comboUzytkownicyNowy.Margin = new System.Windows.Forms.Padding(4);
            this.comboUzytkownicyNowy.Name = "comboUzytkownicyNowy";
            this.comboUzytkownicyNowy.Size = new System.Drawing.Size(212, 24);
            this.comboUzytkownicyNowy.TabIndex = 10;
            // 
            // txtUzytkownicyNowyHaslo
            // 
            this.txtUzytkownicyNowyHaslo.Location = new System.Drawing.Point(161, 96);
            this.txtUzytkownicyNowyHaslo.Margin = new System.Windows.Forms.Padding(4);
            this.txtUzytkownicyNowyHaslo.Name = "txtUzytkownicyNowyHaslo";
            this.txtUzytkownicyNowyHaslo.Size = new System.Drawing.Size(212, 22);
            this.txtUzytkownicyNowyHaslo.TabIndex = 9;
            // 
            // txtUzytkownicyNowyLogin
            // 
            this.txtUzytkownicyNowyLogin.Location = new System.Drawing.Point(161, 52);
            this.txtUzytkownicyNowyLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtUzytkownicyNowyLogin.Name = "txtUzytkownicyNowyLogin";
            this.txtUzytkownicyNowyLogin.Size = new System.Drawing.Size(212, 22);
            this.txtUzytkownicyNowyLogin.TabIndex = 8;
            // 
            // btnUzytkownicyAnuluj
            // 
            this.btnUzytkownicyAnuluj.Location = new System.Drawing.Point(16, 242);
            this.btnUzytkownicyAnuluj.Margin = new System.Windows.Forms.Padding(4);
            this.btnUzytkownicyAnuluj.Name = "btnUzytkownicyAnuluj";
            this.btnUzytkownicyAnuluj.Size = new System.Drawing.Size(100, 30);
            this.btnUzytkownicyAnuluj.TabIndex = 12;
            this.btnUzytkownicyAnuluj.Text = "Anuluj";
            this.btnUzytkownicyAnuluj.UseVisualStyleBackColor = true;
            // 
            // btnUzytkownicyZapisz
            // 
            this.btnUzytkownicyZapisz.Location = new System.Drawing.Point(273, 242);
            this.btnUzytkownicyZapisz.Margin = new System.Windows.Forms.Padding(4);
            this.btnUzytkownicyZapisz.Name = "btnUzytkownicyZapisz";
            this.btnUzytkownicyZapisz.Size = new System.Drawing.Size(100, 30);
            this.btnUzytkownicyZapisz.TabIndex = 11;
            this.btnUzytkownicyZapisz.Text = "Zapisz";
            this.btnUzytkownicyZapisz.UseVisualStyleBackColor = true;
            // 
            // NowyUzytkownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 308);
            this.Controls.Add(this.btnUzytkownicyAnuluj);
            this.Controls.Add(this.btnUzytkownicyZapisz);
            this.Controls.Add(this.comboUzytkownicyNowy);
            this.Controls.Add(this.txtUzytkownicyNowyHaslo);
            this.Controls.Add(this.txtUzytkownicyNowyLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NowyUzytkownikForm";
            this.Text = "Nowy Uzytkownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboUzytkownicyNowy;
        private System.Windows.Forms.TextBox txtUzytkownicyNowyHaslo;
        private System.Windows.Forms.TextBox txtUzytkownicyNowyLogin;
        private System.Windows.Forms.Button btnUzytkownicyAnuluj;
        private System.Windows.Forms.Button btnUzytkownicyZapisz;
    }
}