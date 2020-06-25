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

namespace QuanLyKS
{
    public partial class CashInfoForm : Form
    {
        DoanhThu a;
        public CashInfoForm(Object dt)
        {
            a = dt as DoanhThu;
            InitializeComponent();
            load();
            
        }
        public void load()
        {
            tbNow.Text = String.Format("{0:dd/MM/yyyy HH:mm}", DateTime.Now);
            tbThu.Text = String.Format("{0:n0}", a.Thu);
            string query = "select TenPhong,TenKH from Phong inner join Bill on Phong.IdBill=Bill.IdBill inner join KhachHang on KhachHang.IdKH=Bill.IdKH where Phong.IdBill='" + a.IdBill + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        tbDAnhMuc.Text = rd.GetString(0) + ".  " + rd.GetString(1);
                    }
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            a.MaNV = MainForm.m.NV;
            a.DanhMuc = tbDAnhMuc.Text;
            a.Note = tbNote.Text;
            string query = "insert into DoanhThu(Ngay,IdBill,MaNV,DanhMuc,Thu,Chi,Note)" +
                " values ('" + String.Format("{0:MM/dd/yyyy HH:mm}", DateTime.Now) + "','" + a.IdBill + "',N'" + a.MaNV + "',N'" +
                a.DanhMuc + "'," + a.Thu + ",0,N'" + a.Note + "')";
            string query2 = "update Phong set IdBill=null,TrangThai=3 where IdBill='" + a.IdBill + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(query2, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            this.Dispose();
        }
    }
}
