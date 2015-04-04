namespace Warehouse_Management_System
{
    partial class KlienciUserControl
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
            this.nipTb = new MetroFramework.Controls.MetroTextBox();
            this.nazwaTb = new MetroFramework.Controls.MetroTextBox();
            this.usunBtn = new MetroFramework.Controls.MetroButton();
            this.edytujBtn = new MetroFramework.Controls.MetroButton();
            this.miastoTb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // nipTb
            // 
            this.nipTb.Enabled = false;
            this.nipTb.Location = new System.Drawing.Point(385, 3);
            this.nipTb.Name = "nipTb";
            this.nipTb.Size = new System.Drawing.Size(92, 23);
            this.nipTb.TabIndex = 89;
            // 
            // nazwaTb
            // 
            this.nazwaTb.Enabled = false;
            this.nazwaTb.Location = new System.Drawing.Point(3, 3);
            this.nazwaTb.Name = "nazwaTb";
            this.nazwaTb.Size = new System.Drawing.Size(260, 23);
            this.nazwaTb.TabIndex = 77;
            // 
            // usunBtn
            // 
            this.usunBtn.Location = new System.Drawing.Point(546, 3);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(48, 23);
            this.usunBtn.TabIndex = 91;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // edytujBtn
            // 
            this.edytujBtn.Location = new System.Drawing.Point(483, 3);
            this.edytujBtn.Name = "edytujBtn";
            this.edytujBtn.Size = new System.Drawing.Size(57, 23);
            this.edytujBtn.TabIndex = 90;
            this.edytujBtn.Text = "Edytuj";
            this.edytujBtn.Click += new System.EventHandler(this.edytujBtn_Click);
            // 
            // miastoTb
            // 
            this.miastoTb.Enabled = false;
            this.miastoTb.Location = new System.Drawing.Point(269, 3);
            this.miastoTb.Name = "miastoTb";
            this.miastoTb.Size = new System.Drawing.Size(110, 23);
            this.miastoTb.TabIndex = 92;
            // 
            // KlienciUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.miastoTb);
            this.Controls.Add(this.usunBtn);
            this.Controls.Add(this.edytujBtn);
            this.Controls.Add(this.nipTb);
            this.Controls.Add(this.nazwaTb);
            this.Name = "KlienciUserControl";
            this.Size = new System.Drawing.Size(597, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nipTb;
        private MetroFramework.Controls.MetroTextBox nazwaTb;
        private MetroFramework.Controls.MetroButton usunBtn;
        private MetroFramework.Controls.MetroButton edytujBtn;
        private MetroFramework.Controls.MetroTextBox miastoTb;
    }
}
