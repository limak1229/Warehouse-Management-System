namespace Warehouse_Management_System
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.FakturyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ProduktyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.KlienciTabPage = new MetroFramework.Controls.MetroTabPage();
            this.UżytkownicyTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.UstawieniaTabPage = new MetroFramework.Controls.MetroTabPage();
            this.DodajFaktureButton = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsunFaktureButton = new MetroFramework.Controls.MetroButton();
            this.metroTabControl.SuspendLayout();
            this.FakturyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.FakturyTabPage);
            this.metroTabControl.Controls.Add(this.ProduktyTabPage);
            this.metroTabControl.Controls.Add(this.KlienciTabPage);
            this.metroTabControl.Controls.Add(this.UżytkownicyTabPage);
            this.metroTabControl.Controls.Add(this.UstawieniaTabPage);
            this.metroTabControl.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.SelectedTab = FakturyTabPage;
            this.metroTabControl.Size = new System.Drawing.Size(616, 254);
            this.metroTabControl.TabIndex = 0;
            // 
            // FakturyTabPage
            // 
            this.FakturyTabPage.Controls.Add(this.UsunFaktureButton);
            this.FakturyTabPage.Controls.Add(this.dataGridView1);
            this.FakturyTabPage.Controls.Add(this.DodajFaktureButton);
            this.FakturyTabPage.HorizontalScrollbarBarColor = true;
            this.FakturyTabPage.Location = new System.Drawing.Point(4, 35);
            this.FakturyTabPage.Name = "FakturyTabPage";
            this.FakturyTabPage.Size = new System.Drawing.Size(608, 215);
            this.FakturyTabPage.TabIndex = 0;
            this.FakturyTabPage.Text = "Faktury";
            this.FakturyTabPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FakturyTabPage.VerticalScrollbarBarColor = true;
            // 
            // ProduktyTabPage
            // 
            this.ProduktyTabPage.HorizontalScrollbarBarColor = true;
            this.ProduktyTabPage.Location = new System.Drawing.Point(4, 35);
            this.ProduktyTabPage.Name = "ProduktyTabPage";
            this.ProduktyTabPage.Size = new System.Drawing.Size(608, 215);
            this.ProduktyTabPage.TabIndex = 1;
            this.ProduktyTabPage.Text = "Produkty";
            this.ProduktyTabPage.VerticalScrollbarBarColor = true;
            // 
            // KlienciTabPage
            // 
            this.KlienciTabPage.HorizontalScrollbarBarColor = true;
            this.KlienciTabPage.Location = new System.Drawing.Point(4, 35);
            this.KlienciTabPage.Name = "KlienciTabPage";
            this.KlienciTabPage.Size = new System.Drawing.Size(608, 215);
            this.KlienciTabPage.TabIndex = 2;
            this.KlienciTabPage.Text = "Klienci";
            this.KlienciTabPage.VerticalScrollbarBarColor = true;
            // 
            // UżytkownicyTabPage
            // 
            this.UżytkownicyTabPage.HorizontalScrollbarBarColor = true;
            this.UżytkownicyTabPage.Location = new System.Drawing.Point(4, 35);
            this.UżytkownicyTabPage.Name = "UżytkownicyTabPage";
            this.UżytkownicyTabPage.Size = new System.Drawing.Size(608, 215);
            this.UżytkownicyTabPage.TabIndex = 3;
            this.UżytkownicyTabPage.Text = "Użytkownicy";
            this.UżytkownicyTabPage.VerticalScrollbarBarColor = true;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // UstawieniaTabPage
            // 
            this.UstawieniaTabPage.HorizontalScrollbarBarColor = true;
            this.UstawieniaTabPage.Location = new System.Drawing.Point(4, 35);
            this.UstawieniaTabPage.Name = "UstawieniaTabPage";
            this.UstawieniaTabPage.Size = new System.Drawing.Size(608, 215);
            this.UstawieniaTabPage.TabIndex = 4;
            this.UstawieniaTabPage.Text = "Ustawienia";
            this.UstawieniaTabPage.VerticalScrollbarBarColor = true;
            // 
            // DodajFaktureButton
            // 
            this.DodajFaktureButton.Location = new System.Drawing.Point(4, 4);
            this.DodajFaktureButton.Name = "DodajFaktureButton";
            this.DodajFaktureButton.Size = new System.Drawing.Size(101, 23);
            this.DodajFaktureButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.DodajFaktureButton.TabIndex = 2;
            this.DodajFaktureButton.Text = "Dodaj fakture";
            this.DodajFaktureButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DodajFaktureButton.Click += new System.EventHandler(this.DodajFaktureButton_Click);
            // 
            // dataGridView1
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.dataGridView1, true);
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // UsunFaktureButton
            // 
            this.UsunFaktureButton.Location = new System.Drawing.Point(111, 4);
            this.UsunFaktureButton.Name = "UsunFaktureButton";
            this.UsunFaktureButton.Size = new System.Drawing.Size(89, 23);
            this.UsunFaktureButton.TabIndex = 4;
            this.UsunFaktureButton.Text = "Usuń fakture";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(662, 340);
            this.Controls.Add(this.metroTabControl);
            this.Name = "HomeForm";
            this.Resizable = false;
            this.Text = "Warehouse Management System";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.metroTabControl.ResumeLayout(false);
            this.FakturyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage FakturyTabPage;
        private MetroFramework.Controls.MetroTabPage ProduktyTabPage;
        private MetroFramework.Controls.MetroTabPage KlienciTabPage;
        private MetroFramework.Controls.MetroTabPage UżytkownicyTabPage;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Controls.MetroTabPage UstawieniaTabPage;
        private MetroFramework.Controls.MetroButton DodajFaktureButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton UsunFaktureButton;



    }
}

