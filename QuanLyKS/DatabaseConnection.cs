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
                            Zoom a = new Zoom(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),"");
                            if (!reader.IsDBNull(3)) a.setIdBill(reader.GetString(3));
                            list.Add(a);
                        }
                    }
                }
                conn.Close();
            }
            return list;

        }
        public List<ThongTinDichVu> getDV(string idBill)
        {
            List<ThongTinDichVu> serviceInfo = new List<ThongTinDichVu>();
            string query = "select TenDV,DonGia,SoLuong from DichVu join BillInfo on DichVu.IdDV=BillInfo.IdDV where IdBill='" + idBill + "'";
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using(SqlDataReader reader = cmd.ExecuteReader()){
                    while(reader.Read()){
                        ThongTinDichVu info = new ThongTinDichVu(reader.GetString(0),reader.GetInt32(1),reader.GetInt32(2));
                        serviceInfo.Add(info);
                    }
                }

                conn.Close();
            }
            return serviceInfo;
        }

        public List<KhachHang> getListKH()
        {
            List<KhachHang> listKH = new List<KhachHang>();
            string query = "select * from Khachhang";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KhachHang kh = new KhachHang(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                        listKH.Add(kh);
                    }
                }

                conn.Close();
            }
            return listKH;
        }

        public currentCustomerInfo getCurrentInfo(int idPhong)
        {
            currentCustomerInfo info = new currentCustomerInfo();
            string query = "select tenKH,CI,CO,TenPhong from Phong inner join Bill on Phong.IdBill=Bill.IdBill inner join KhachHang on  KhachHang.IdKH = Bill.IdKH where phong.IdPhong="+idPhong;
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        info = new currentCustomerInfo(reader.GetString(0), reader.GetDateTime(1), reader.GetDateTime(2), reader.GetString(3));
                    }
                }
                conn.Close();

            }
            return info;
        }
    }
}


