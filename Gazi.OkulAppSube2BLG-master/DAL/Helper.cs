using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cn.Open();
                        return cmd.ExecuteNonQuery();
                    }// Dispose() burada otomatik olarak çağrılır
                }//Nesneler artık ihtiyaç duyulmadığında yönetilmeyen kaynakların (örneğin, dosya tutanakları, veritabanı bağlantıları, ağ soketleri) doğru şekilde serbest bırakılmasını sağlar.
            }
            catch (Exception)
            {
                MessageBox.Show("ExecuteNonQuery İLE OLANDA HATA ALDIN");
                throw;
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cn.Open();
                        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    }// Dispose() burada otomatik olarak çağrılır
                }// Nesneler artık ihtiyaç duyulmadığında yönetilmeyen kaynakların (örneğin, dosya tutanakları, veritabanı bağlantıları, ağ soketleri) doğru şekilde serbest bırakılmasını sağlar.
            }
            catch (Exception)
            {
                MessageBox.Show("ExecuteNonQuery İLE OLANDA HATA ALDIN");
                throw;
            }
        }
    }
}
