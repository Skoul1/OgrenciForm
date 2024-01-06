using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace OkulApp.BLL//Bussiness Logic Layer
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p =
                {
                new SqlParameter("@Ad",ogr.Ad),
                new SqlParameter("@Soyad",ogr.Soyad),
                new SqlParameter("@Numara",ogr.Numara)
                };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into OgrencilerTBL (Ad,Soyad,Numara) values (@Ad,@Soyad,@Numara)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                //{
                //    //cn.Close();
                //    cn.Dispose();

                //    cmd.Dispose();
                //}
            }
        }
        public Ogrenci OgrenciBul(string Numara)
        {
            var hlp = new Helper();
            SqlParameter[] p = { new SqlParameter("@Numara", Numara) };
            var dr = hlp.ExecuteReader("Select OgrencıID,Ad,Soyad,Numara From OgrencilerTBL where Numara=@Numara", p);
            Ogrenci ogr = null;
            if (dr.Read())
            {
                ogr = new Ogrenci();
                ogr.Ad = dr["Ad"].ToString();
                ogr.Soyad = dr["Soyad"].ToString();
                ogr.Numara = dr["Numara"].ToString();
                ogr.Ogrenciid = Convert.ToInt32(dr["OgrencıID"]);
            }
            dr.Close();
            return ogr;
        }
        public bool OgrenciSil(int id)
        {
            SqlParameter[] p = { new SqlParameter("@id", id) };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Delete from OgrencilerTBL where OgrencıID=@id", p) > 0;
        }

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            SqlParameter[] p = { 
            new SqlParameter("@ad", ogr.Ad),
            new SqlParameter("@soyad", ogr.Soyad) ,
            new SqlParameter("@numara", ogr.Numara) ,
            new SqlParameter("@id", ogr.Ogrenciid) };
            
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Update OgrencilerTBL set Ad=@ad, Soyad=@soyad, Numara=@numara where OgrencıID=@id", p) > 0;
        }


    }
}
