using Gazi.OkulAppSube2BLG;
using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmOgrBul
{
    public partial class FrmOgrBul : Form
    {
        frmOgrKayit frm;
        public FrmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciBul(txtNumara.Text.Trim());
            if (ogr!=null)
            {
                frm.txtAd.Text = ogr.Ad;
                frm.txtSoyad.Text = ogr.Soyad;  
                frm.txtNumara.Text = ogr.Numara;    
            }
            else
            {
                MessageBox.Show("OGRENCI BULUNAMADI!");
            }
        }
    }
}
