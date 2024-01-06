using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.OkulAppSube2BLG
{
    public partial class frmOgrKayit : Form
    {
        public int Ogrenciİd { get; set; }
        public frmOgrKayit()
        {
            InitializeComponent();
            if (txtAd.Text != null && txtSoyad.Text != null)
            {
                Btn_guncelle.Enabled = false;
                Btn_SİL.Enabled = false;
            }
            else
            {
                Btn_guncelle.Enabled = true;
                Btn_SİL.Enabled = true;
            }

        }

        //Dispose
        //Garbage Collector
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //var ogrenci = new Ogrenci();
                //ogrenci.Ad = txtAd.Text.Trim();
                //ogrenci.Soyad = txtSoyad.Text.Trim();
                //ogrenci.Numara = txtNumara.Text.Trim();

                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme başarılı!" : "Ekleme başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!!");
            }
        }

        private void btn_bul(object sender, EventArgs e)
        {
            var frm = new FrmOgrBul(this);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            MessageBox.Show(obl.OgrenciSil(Ogrenciİd) ? "Silme Başarılı!" : "Başarısız!");
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            MessageBox.Show(obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), Ogrenciid = Ogrenciİd }) ? "Güncelleme Başarılı!" : "Güncelleme Başarısız!");
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
        }
    }

    interface ITransfer
    {
        int EFT(string aliciiban, string gondereniban, double tutar);
        int Havale(string aliciiban, string gondereniban, double tutar, DateTime tarih);
    }

    class TransferIslemleri : ITransfer
    {
        public int EFT(string aliciiban, string gondereniban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string aliciiban, string gondereniban, double tutar, DateTime tarih)
        {
            throw new NotImplementedException();
        }
    }
}

//n Katmanlı Mimari
