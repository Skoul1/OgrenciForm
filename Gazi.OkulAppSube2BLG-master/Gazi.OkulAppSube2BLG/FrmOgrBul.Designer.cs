namespace Gazi.OkulAppSube2BLG
{
    partial class FrmOgrBul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnARA = new System.Windows.Forms.Button();
            this.Numara = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnARA);
            this.groupBox1.Controls.Add(this.Numara);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KULLANICI ARAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICIYI BUL";
            // 
            // btnARA
            // 
            this.btnARA.Location = new System.Drawing.Point(6, 104);
            this.btnARA.Name = "btnARA";
            this.btnARA.Size = new System.Drawing.Size(216, 23);
            this.btnARA.TabIndex = 1;
            this.btnARA.Text = "ARA";
            this.btnARA.UseVisualStyleBackColor = true;
            this.btnARA.Click += new System.EventHandler(this.btnARA_Click);
            // 
            // Numara
            // 
            this.Numara.Location = new System.Drawing.Point(6, 78);
            this.Numara.Name = "Numara";
            this.Numara.Size = new System.Drawing.Size(216, 20);
            this.Numara.TabIndex = 0;
            // 
            // FrmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(259, 196);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOgrBul";
            this.Text = "FrmOgrBul";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnARA;
        private System.Windows.Forms.TextBox Numara;
    }
}