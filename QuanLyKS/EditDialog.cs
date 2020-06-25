using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using System.Data.SqlClient;

namespace QuanLyKS
{
    public partial class EditDialog : Form
    {
        private string idBill;
        private int curentZoom;
        private string dv;
        List<ThongTinDichVu> listDV;
        string iddv = "";


        public EditDialog(int s, string id, string d)
        {
            idBill = id;
            this.curentZoom = s;
            this.dv = d;

            InitializeComponent();
            loadcb();
        }
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //public void load()
        //{

        //    #region
        //    //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
        //    //ExcelWorksheet a = package.Workbook.Worksheets[0];
        //    //for (int i = 1; i <= a.Dimension.End.Row; i++)
        //    //{
        //    //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == curentZoom)
        //    //    {
        //    //        tbDichVu.Text = Convert.ToString(a.Cells[i + 3+n, 1].Value);
        //    //        tbDonGia.Text = Convert.ToString(a.Cells[i + 3+n, 2].Value);
        //    //        tbSoLuong.Text = Convert.ToString(a.Cells[i + 3+n, 3].Value);
        //    //    }
        //    //}
        //    #endregion
        //}
        public void loadcb()
        {
            listDV = new DatabaseConnection().getDV(idBill, DatabaseConnection.EDIT);
            comboBox1.DataSource = listDV;
            comboBox1.DisplayMember = "Dv";
            foreach (ThongTinDichVu item in listDV)
            {
                if (item.Dv == dv)
                {
                    comboBox1.SelectedItem = item;
                    tbDonGia.Text = Convert.ToString(item.Dg);
                    tbSoLuong.Text = Convert.ToString(item.Sl);

                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool b;
            string getid="select IdDV from DichVu where TenDV=N'"+comboBox1.Text+"'";
            
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand CmdId = new SqlCommand(getid, conn);
                using(SqlDataReader rd = CmdId.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        iddv = rd.GetString(0);
                    }
                }
                string query = "update BillInfo set DonGia =" + tbDonGia.Text + ", SoLuong = " + tbSoLuong.Text + " where IdDV='" + iddv + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                MessageBox.Show(query);
                b=(cmd.ExecuteNonQuery()>0);
                conn.Close();
            }
            if (b)
            {
                MessageBox.Show("Sửa thành công!");
                this.Dispose();
            }
            else MessageBox.Show("Thất bại");
            #region
            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == curentZoom)
            //    {
            //        a.Cells[i + 3 + n, 1].Value = tbDichVu.Text;
            //        a.Cells[i + 3 + n, 2].Value = tbDonGia.Text;
            //        a.Cells[i + 3 + n, 3].Value = tbSoLuong.Text;
            //    }
            //}
            //Byte[] bin = package.GetAsByteArray();
            //File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            //this.Dispose();
            #endregion
        }

    }
}
