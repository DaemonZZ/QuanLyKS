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
        public const string ADD = "ADD";
        public const string EDIT = "EDIT";
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
                            Zoom a = new Zoom(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), "");
                            if (!reader.IsDBNull(3)) a.setIdBill(reader.GetString(3));
                            list.Add(a);
                        }
                    }
                }
                conn.Close();
            }
            return list;

        }
        public List<ThongTinDichVu> getDV(string idBill, string a)
        {

            List<ThongTinDichVu> serviceInfo = new List<ThongTinDichVu>();
            string query = "";
            if (a == "ADD") query = "select TenDV,DichVu.DonGia,SoLuong from DichVu join BillInfo on DichVu.IdDV=BillInfo.IdDV where IdBill='" + idBill + "'";
            if (a == "EDIT") query = "select TenDV,BillInfo.DonGia,SoLuong from DichVu join BillInfo on DichVu.IdDV=BillInfo.IdDV where IdBill='" + idBill + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongTinDichVu info;
                        info = new ThongTinDichVu(reader.GetString(0), 0, 0);
                        if (!reader.IsDBNull(1)) info.Dg = reader.GetInt32(1);
                        if (!reader.IsDBNull(2)) info.Sl = reader.GetInt32(2);
                        info.Sum = info.Sl * info.Dg;
                        serviceInfo.Add(info);
                        //MessageBox.Show(info.Dg.ToString() + "-------" + info.Sl.ToString() + "----------+" + info.Sum.ToString());
                    }
                }

                conn.Close();
            }
            return serviceInfo;
        }

        public List<ThongTinDichVu> getDV()
        {
            List<ThongTinDichVu> serviceInfo = new List<ThongTinDichVu>();

            string query = "select IdDV,TenDV,DonGia from DichVu";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongTinDichVu info;
                        info = new ThongTinDichVu(reader.GetString(0), reader.GetString(1), 0);
                        if (!reader.IsDBNull(2)) info.Dg = reader.GetInt32(2);

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
            string query = "select tenKH,CI,CO,TenPhong,LichDat from Phong inner join Bill on Phong.IdBill=Bill.IdBill inner join KhachHang on  KhachHang.IdKH = Bill.IdKH where phong.IdPhong=" + idPhong;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        info = new currentCustomerInfo(reader.GetString(0), "", "", reader.GetString(3), "");
                        if (!reader.IsDBNull(1)) info.CI1 = reader.GetDateTime(1).ToString();
                        if (!reader.IsDBNull(2)) info.CO1 = reader.GetDateTime(2).ToString();
                        if (!reader.IsDBNull(4)) info.Order = reader.GetDateTime(4).ToString();
                    }
                }
                conn.Close();

            }
            return info;
        }
        public void zoomResetStatus(int phong)
        {
            string query = "update Phong set idbill=null where idphong=" + phong;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public string createNextBill()
        {
            string nextBill = "";
            int count = 1;
            string query = "select  IdBill from Bill";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read()) count++;
                }
                conn.Close();
            }
            nextBill = "B" + count;
            return nextBill;
        }
        public string createNextCustomer()
        {
            string nextCs = "";
            int count = 1;
            string query = "select IdKH from KhachHang";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read()) count++;
                }
                conn.Close();
            }
            nextCs = "KH" + count;
            return nextCs;
        }
        public bool checkOldCustomer(KhachHang a) // Kiểm tra khách hàng đã từng vào chưa
        {
            bool b;
            string query = "";
            if (a.Cmnd != "") query = "select CMND from KhachHang where CMND='" + a.Cmnd + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read()) b = true;
                    else b = false;
                }
                conn.Close();

            }
            return b;
        }
        public string getIDBill(int zoom)
        {
            string query = "select * from Phong where IdPhong='" + zoom + "'";
            string bill = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        bill = rd.GetString(3);
                    }
                }
                conn.Close();
            }
            return bill;
        }
        public bool addDV(string bill, ThongTinDichVu dv)
        {
            string query = "insert into BillInfo(IdBill,IdDV,DonGia,SoLuong) " +
                "values ('" + bill + "','" + dv.Dv + "'," + dv.Dg + "," + dv.Sl + ")";
            bool b = false;

            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() > 0) b = true;
                conn.Close();
            }
            return b;
        }
        public string getNoteOfZoom(int Idphong)
        {
            string Gc = "";
            string query = "select Note from Phong where IdPhong =" + Idphong;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        if (!rd.IsDBNull(0)) Gc = rd.GetString(0);
                        else Gc = "";
                    }
                }
                conn.Close();
            }
            return Gc;
        }
        public List<DoanhThu> getListDT(string date)
        {
            List<DoanhThu> listDT = new List<DoanhThu>();
            DateTime sDate;
            string query = "select * from DoanhThu ";
            string filt = " where Ngay ='" + date + "'";
            string sort = " order by Ngay DESC";
            if (date == "")
            {
                listDT = new List<DoanhThu>();
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query + sort, conn);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            DoanhThu dt = new DoanhThu(rd.GetDateTime(0), "", rd.GetString(2), rd.GetString(3), 0, 0, "");
                            if (!rd.IsDBNull(1)) dt.IdBill = rd.GetString(1);
                            if (!rd.IsDBNull(4)) dt.Thu = rd.GetInt32(4);
                            if (!rd.IsDBNull(5)) dt.Chi = rd.GetInt32(5);
                            if (!rd.IsDBNull(6)) dt.Note = rd.GetString(6);
                            listDT.Add(dt);
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                try
                {
                    sDate = Convert.ToDateTime(date);
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query + filt + sort, conn);
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                DoanhThu dt = new DoanhThu(rd.GetDateTime(0), "", rd.GetString(2), rd.GetString(3), 0, 0, "");
                                if (!rd.IsDBNull(1)) dt.IdBill = rd.GetString(1);
                                if (!rd.IsDBNull(4)) dt.Thu = rd.GetInt32(4);
                                if (!rd.IsDBNull(5)) dt.Chi = rd.GetInt32(5);
                                if (!rd.IsDBNull(6)) dt.Note = rd.GetString(6);
                                listDT.Add(dt);
                            }
                        }
                        conn.Close();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listDT;
        }
        public List<DanhBa> getListDB()
        {
            List<DanhBa> listDB = new List<DanhBa>();
            string query = "select * from DanhBa";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DanhBa kh = new DanhBa(reader.GetString(0), reader.GetString(1));
                        listDB.Add(kh);
                    }
                }

                conn.Close();
            }
            return listDB;
        }
        public List<DanhBa> searchListDB(string s)
        {
            List<DanhBa> listDB = new List<DanhBa>();
            string query = "select * from DanhBa where Ten like N'%"+s+"'";
            
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DanhBa kh = new DanhBa(reader.GetString(0), reader.GetString(1));
                        listDB.Add(kh);
                    }
                }

                conn.Close();
            }
            return listDB;
        }
    }
}



