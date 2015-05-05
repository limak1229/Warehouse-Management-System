namespace Warehouse_Management_System
{
    partial class Browser
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
            this.wB = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wB
            // 
            this.wB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wB.Location = new System.Drawing.Point(0, 0);
            this.wB.MinimumSize = new System.Drawing.Size(20, 20);
            this.wB.Name = "wB";
            this.wB.Size = new System.Drawing.Size(751, 502);
            this.wB.TabIndex = 0;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 502);
            this.Controls.Add(this.wB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wB;
    }
}