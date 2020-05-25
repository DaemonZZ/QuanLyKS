using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKS
{
    class DatabaseConnection
    {
        public DatabaseConnection()
        {

        }

        public List<NhanVien> getListNV()
        {

            List<NhanVien> listNV = new List<NhanVien>();
            string query = "select * from NhanVien";

            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                //SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            NhanVien a = new NhanVien(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            listNV.Add(a);
                            //Console.WriteLine(a.getTen());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa có dữ liệu nhân viên");
                    }
                }
                conn.Close();
            }
            return listNV;
        }
        public List<KhachHang> getCurrentCustomer()
        {
            List<KhachHang> listKH = new List<KhachHang>();
            return listKH;
        }
        public List<Zoom> getListZoom()
        {
            List<Zoom> list = new List<Zoom>();
            string query = "select * from Phong";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                //SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Zoom a = new Zoom(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2));
                            list.Add(a);
                        }
                    }
                }
            }
            return list;

        }
    }
}


