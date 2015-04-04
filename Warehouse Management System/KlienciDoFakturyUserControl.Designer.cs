namespace Warehouse_Management_System
{
    partial class KlienciDoFakturyUserControl
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
            this.miastoTb = new MetroFramework.Controls.MetroTextBox();
            this.nipTb = new MetroFramework.Controls.MetroTextBox();
            this.nazwaTb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // miastoTb
            // 
            this.miastoTb.Enabled = false;
            this.miastoTb.Location = new System.Drawing.Point(269, 3);
            this.miastoTb.Name = "miastoTb";
            this.miastoTb.Size = new System.Drawing.Size(110, 23);
            this.miastoTb.TabIndex = 2;
            // 
            // nipTb
            // 
            this.nipTb.Enabled = false;
            this.nipTb.Location = new System.Drawing.Point(385, 3);
            this.nipTb.Name = "nipTb";
            this.nipTb.Size = new System.Drawing.Size(119, 23);
            this.nipTb.TabIndex = 3;
            // 
            // nazwaTb
            // 
            this.nazwaTb.Enabled = false;
            this.nazwaTb.Location = new System.Drawing.Point(3, 3);
            this.nazwaTb.Name = "nazwaTb";
            this.nazwaTb.Size = new System.Drawing.Size(260, 23);
            this.nazwaTb.TabIndex = 1;
            // 
            // KlienciDoFakturyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.miastoTb);
            this.Controls.Add(this.nipTb);
            this.Controls.Add(this.nazwaTb);
            this.Name = "KlienciDoFakturyUserControl";
            this.Size = new System.Drawing.Size(507, 29);
            this.MouseLeave += new System.EventHandler(this.KlienciDoFakturyUserControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KlienciDoFakturyUserControl_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox miastoTb;
        private MetroFramework.Controls.MetroTextBox nipTb;
        private MetroFramework.Controls.MetroTextBox nazwaTb;
    }
}
