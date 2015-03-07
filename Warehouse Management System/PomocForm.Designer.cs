namespace Warehouse_Management_System
{
    partial class Pomoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomoc));
            this.btnPomocOk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPomocOk
            // 
            this.btnPomocOk.Location = new System.Drawing.Point(9, 349);
            this.btnPomocOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPomocOk.Name = "btnPomocOk";
            this.btnPomocOk.Size = new System.Drawing.Size(69, 31);
            this.btnPomocOk.TabIndex = 0;
            this.btnPomocOk.Text = "OK";
            this.btnPomocOk.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 335);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Pomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 385);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPomocOk);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pomoc";
            this.Text = "Pomoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPomocOk;
        private System.Windows.Forms.TextBox textBox1;
    }
}