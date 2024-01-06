namespace Gazi.OkulAppSube2BLG
{
    partial class frmOgrKayit
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
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.Btn_BUL = new System.Windows.Forms.Button();
            this.Btn_SİL = new System.Windows.Forms.Button();
            this.Btn_guncelle = new System.Windows.Forms.Button();
            this.grpOgrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.Controls.Add(this.txtNumara);
            this.grpOgrenci.Controls.Add(this.lblAd);
            this.grpOgrenci.Controls.Add(this.lblSoyad);
            this.grpOgrenci.Controls.Add(this.lblNumara);
            this.grpOgrenci.Controls.Add(this.txtSoyad);
            this.grpOgrenci.Controls.Add(this.txtAd);
            this.grpOgrenci.Location = new System.Drawing.Point(12, 12);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Size = new System.Drawing.Size(211, 152);
            this.grpOgrenci.TabIndex = 0;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "Öğrenci Bilgileri";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(83, 105);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(29, 37);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(29, 73);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(29, 112);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(44, 13);
            this.lblNumara.TabIndex = 6;
            this.lblNumara.Text = "Numara";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(83, 66);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(83, 30);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(95, 181);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Btn_BUL
            // 
            this.Btn_BUL.Location = new System.Drawing.Point(242, 49);
            this.Btn_BUL.Name = "Btn_BUL";
            this.Btn_BUL.Size = new System.Drawing.Size(75, 23);
            this.Btn_BUL.TabIndex = 8;
            this.Btn_BUL.Text = "BUL";
            this.Btn_BUL.UseVisualStyleBackColor = true;
            this.Btn_BUL.Click += new System.EventHandler(this.btn_bul);
            // 
            // Btn_SİL
            // 
            this.Btn_SİL.Location = new System.Drawing.Point(242, 76);
            this.Btn_SİL.Name = "Btn_SİL";
            this.Btn_SİL.Size = new System.Drawing.Size(75, 23);
            this.Btn_SİL.TabIndex = 8;
            this.Btn_SİL.Text = "SİL";
            this.Btn_SİL.UseVisualStyleBackColor = true;
            this.Btn_SİL.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.Location = new System.Drawing.Point(242, 105);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.Btn_guncelle.TabIndex = 8;
            this.Btn_guncelle.Text = "GÜNCELLE";
            this.Btn_guncelle.UseVisualStyleBackColor = true;
            this.Btn_guncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 217);
            this.Controls.Add(this.Btn_guncelle);
            this.Controls.Add(this.Btn_SİL);
            this.Controls.Add(this.Btn_BUL);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpOgrenci);
            this.Name = "frmOgrKayit";
            this.Text = "Öğrenci Kayıt İşlemi";
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenci;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button Btn_BUL;
        public System.Windows.Forms.TextBox txtNumara;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.Button Btn_SİL;
        public System.Windows.Forms.Button Btn_guncelle;
    }
}

