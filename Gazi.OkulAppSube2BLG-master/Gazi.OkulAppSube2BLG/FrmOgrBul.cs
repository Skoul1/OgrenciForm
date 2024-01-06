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

namespace Gazi.OkulAppSube2BLG
{
    public partial class FrmOgrBul : Form
    {
        frmOgrKayit frm;
        public FrmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnARA_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciBul(Numara.Text.Trim());
            if (ogr != null)
            {
                frm.txtAd.Text = ogr.Ad;
                frm.txtSoyad.Text = ogr.Soyad;
                frm.txtNumara.Text = ogr.Numara;
                frm.Ogrenciİd = ogr.Ogrenciid;
                
                frm.Btn_guncelle.Enabled = true;
                frm.Btn_SİL.Enabled = true;

                FrmOgrBul.ActiveForm.Close(); //MANTIK YÜRÜTEREK BULDUM :)
               
            }
            else
            {
                MessageBox.Show("OGRENCI BULUNAMADI!");
            }
        }
    }
}
