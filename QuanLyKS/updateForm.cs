using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyKS
{
    public partial class updateForm : Form
    {
        public const string ADD = "ADD";
        public const string EDIT = "EDIT";
        private int currentZoom;
        private string type;
        int stt = 0;
        DateTime now = DateTime.Now;
        public void load()
        {
            #region Excel
            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == currentZoom)
            //    {
            //        tbOrder.Text = Convert.ToString(a.Cells[i, 3].Value);
            //        tbTen.Text = Convert.ToString(a.Cells[i + 1, 1].Value);
            //        tbZoom.Text = currentZoom;
            //        tbCI.Text = Convert.ToString(a.Cells[i + 1, 3].Value);
            //        tbCO.Text = Convert.ToString(a.Cells[i + 1, 4].Value);
            //        if (Convert.ToString(a.Cells[i, 4].Value) == "Yes") checkBox1.Checked = true;
            //        else checkBox1.Checked = false;

            //        int stt = Convert.ToInt16(a.Cells[i + 2, 2].Value);
            //        cbStt.SelectedIndex = stt-1;
            //        switch (stt)
            //        {
            //            case 1:
            //                {
            //                    cbStt.BackColor = Color.Yellow;
            //                    cbStt.ForeColor = Color.Purple;
            //                } break;
            //            case 2:
            //                {
            //                    cbStt.BackColor = Color.Lime;
            //                    cbStt.ForeColor = Color.Red;
            //                }break;
            //            case 3:
            //                {
            //                    cbStt.BackColor = Color.Aqua;
            //                    cbStt.ForeColor = Color.Purple;
            //                } break;
            //            case 4:
            //                {
            //                    cbStt.BackColor = Color.Gray;
            //                    cbStt.ForeColor = Color.White;
            //                } break;
            //            case 5:
            //                {
            //                    cbStt.BackColor = Color.DeepPink;
            //                    cbStt.ForeColor = Color.BlueViolet;
            //                } break;
            //            case 6:
            //                {
            //                    cbStt.BackColor = Color.Red;
            //                    cbStt.ForeColor = Color.GreenYellow;
            //                } break;
            //            case 7:
            //                {
            //                    cbStt.BackColor = Color.Purple;
            //                    cbStt.ForeColor = Color.Lime;
            //                } break;
            //            case 8:
            //                {
            //                    cbStt.BackColor = Color.Orange;
            //                    cbStt.ForeColor = Color.Blue;
            //                } break;

            //        }
            //    }
            //}
            #endregion

            tbZoom.Text = "P" + currentZoom;
            string query = "select TenKH,CI,CO,TenPhong,LichDat,TrangThai,HoaDon,KhachHang.IdKH from KhachHang inner join Bill " +
                "on KhachHang.IdKH=bill.IdKH " +
                "inner join Phong on Bill.IdBill=Phong.IdBill " +
                "where Phong.IdPhong =" + currentZoom;

            int kh;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        tbTen.Text = rd.GetString(0);
                        if (!rd.IsDBNull(1)) tbCI.Text = Convert.ToString(rd.GetDateTime(1));
                        if (!rd.IsDBNull(2)) tbCO.Text = Convert.ToString(rd.GetDateTime(2));
                        tbZoom.Text = rd.GetString(3);
                        if (!rd.IsDBNull(4)) tbOrder.Text = Convert.ToString(rd.GetDateTime(4));
                        stt = rd.GetInt32(5);
                        if (rd.GetBoolean(6)) checkBox1.Checked = true;
                        else checkBox1.Checked = false;
                        label7.Text = rd.GetString(7);
                    }
                }
                conn.Close();
            }
            cbStt.SelectedIndex = stt - 1;
            switch (stt)
            {
                case 1:
                    {
                        cbStt.BackColor = Color.Yellow;
                        cbStt.ForeColor = Color.Purple;
                    }
                    break;
                case 2:
                    {
                        cbStt.BackColor = Color.Lime;
                        cbStt.ForeColor = Color.Red;
                    }
                    break;
                case 3:
                    {
                        cbStt.BackColor = Color.Aqua;
                        cbStt.ForeColor = Color.Purple;
                    }
                    break;
                case 4:
                    {
                        cbStt.BackColor = Color.Gray;
                        cbStt.ForeColor = Color.White;
                    }
                    break;
                case 5:
                    {
                        cbStt.BackColor = Color.DeepPink;
                        cbStt.ForeColor = Color.BlueViolet;
                    }
                    break;
                case 6:
                    {
                        cbStt.BackColor = Color.Red;
                        cbStt.ForeColor = Color.GreenYellow;
                    }
                    break;
                case 7:
                    {
                        cbStt.BackColor = Color.Purple;
                        cbStt.ForeColor = Color.Lime;
                    }
                    break;
                case 8:
                    {
                        cbStt.BackColor = Color.Orange;
                        cbStt.ForeColor = Color.Blue;
                    }
                    break;

            }
        }

        public updateForm(int s, string type)
        {
            this.type = type;

            currentZoom = s;
            InitializeComponent();
            if (type == ADD)
            {
                btnAdd.Visible = true;
                this.Text = Text = "Thêm Thông Tin Khách Hàng";
                label7.Text = new DatabaseConnection().createNextCustomer();
                string sql = "select TrangThai,LichDat from Phong where idPhong="+currentZoom;
                tbCI.Text = String.Format("{0:dd/MM/yyyy HH:mm}", now);
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    using(SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            stt = rd.GetInt32(0) ;
                            if (!rd.IsDBNull(1)) tbOrder.Text=rd.GetDateTime(1).ToString();
                        }
                    }
                    conn.Close();
                }
                cbStt.SelectedIndex = stt - 1;
               
                switch (stt)
                {
                    case 1:
                        {
                            cbStt.BackColor = Color.Yellow;
                            cbStt.ForeColor = Color.Purple;
                        }
                        break;
                    case 2:
                        {
                            cbStt.BackColor = Color.Lime;
                            cbStt.ForeColor = Color.Red;
                        }
                        break;
                    case 3:
                        {
                            cbStt.BackColor = Color.Aqua;
                            cbStt.ForeColor = Color.Purple;
                        }
                        break;
                    case 4:
                        {
                            cbStt.BackColor = Color.Gray;
                            cbStt.ForeColor = Color.White;
                        }
                        break;
                    case 5:
                        {
                            cbStt.BackColor = Color.DeepPink;
                            cbStt.ForeColor = Color.BlueViolet;
                        }
                        break;
                    case 6:
                        {
                            cbStt.BackColor = Color.Red;
                            cbStt.ForeColor = Color.GreenYellow;
                        }
                        break;
                    case 7:
                        {
                            cbStt.BackColor = Color.Purple;
                            cbStt.ForeColor = Color.Lime;
                        }
                        break;
                    case 8:
                        {
                            cbStt.BackColor = Color.Orange;
                            cbStt.ForeColor = Color.Blue;
                        }
                        break;

                }
            }
            else btnEdit.Visible = true;
            load();
        }

        private void cbStt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStt.SelectedIndex > 4) btnAddZoom.Visible = true;
            else btnAddZoom.Visible = false;
            switch (cbStt.SelectedIndex + 1)
            {
                case 1:
                    {
                        cbStt.BackColor = Color.Yellow;
                        cbStt.ForeColor = Color.Purple;
                    }
                    break;
                case 2:
                    {
                        cbStt.BackColor = Color.Lime;
                        cbStt.ForeColor = Color.Red;
                    }
                    break;
                case 3:
                    {
                        cbStt.BackColor = Color.Aqua;
                        cbStt.ForeColor = Color.Purple;
                    }
                    break;
                case 4:
                    {
                        cbStt.BackColor = Color.Gray;
                        cbStt.ForeColor = Color.White;
                    }
                    break;
                case 5:
                    {
                        cbStt.BackColor = Color.DeepPink;
                        cbStt.ForeColor = Color.BlueViolet;
                    }
                    break;
                case 6:
                    {
                        cbStt.BackColor = Color.Red;
                        cbStt.ForeColor = Color.GreenYellow;
                    }
                    break;
                case 7:
                    {
                        cbStt.BackColor = Color.Purple;
                        cbStt.ForeColor = Color.Lime;
                    }
                    break;
                case 8:
                    {
                        cbStt.BackColor = Color.Orange;
                        cbStt.ForeColor = Color.Blue;
                    }
                    break;

            }
            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == currentZoom)
            //    {
            //        a.Cells[i + 2, 2].Value = cbStt.SelectedIndex + 1;
            //    }
            //}

            //Byte[] bin = package.GetAsByteArray();
            //File.WriteAllBytes("CurrentCustomer.xlsx", bin);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbOrder.Text = "";
            tbCI.Text = "";
            tbCO.Text = "";
            tbTen.Text = "";
            cbStt.SelectedIndex = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool test = true; //kiem tra cac tb da dien dung dinh dang chua
            DateTime ci = new DateTime();
            DateTime co = new DateTime();
            DateTime od = new DateTime();
            string sCI, sCO, sOd, ten = "NoName";

            #region
            // var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == currentZoom)
            //    {
            //        if (tbCI.Text != "")
            //        { //Kiểm tra định dang ngày tháng nhập vào
            //            try
            //            {
            //                DateTime ci = Convert.ToDateTime(tbCI.Text);
            //                a.Cells[i + 1, 3].Value = ci.ToString();


            //            }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
            //                test = false;
            //                break;
            //            }
            //        }
            //        else a.Cells[i + 1, 3].Value = "";

            //        if (tbCO.Text != "")
            //        {
            //            try
            //            {
            //                DateTime co = Convert.ToDateTime(tbCO.Text);
            //                a.Cells[i + 1, 4].Value = co.ToString();

            //            }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
            //                test = false;
            //                break;
            //            }
            //        }
            //        else a.Cells[i + 1, 4].Value = "";

            //        if (tbOrder.Text != "")
            //        {
            //            try
            //            {
            //                DateTime od = Convert.ToDateTime(tbOrder.Text);
            //                a.Cells[i , 3].Value = od.ToString();

            //            }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
            //                test = false;
            //                break;
            //            }
            //        }
            //        else a.Cells[i, 3].Value = "";
            //        if (checkBox1.Checked) a.Cells[i, 4].Value = "Yes";
            //        else a.Cells[i, 4].Value = "No";

            //        a.Cells[i + 1, 1].Value = tbTen.Text;
            //        a.Cells[i + 2, 2].Value = cbStt.SelectedIndex + 1;

            //    }
            //}

            //if (test)
            //{
            //    Byte[] bin = package.GetAsByteArray();
            //    File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            #endregion
            if (tbCI.Text != "")
            {
                try
                {
                    ci = Convert.ToDateTime(tbCI.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
                    test = false;
                }
            }
            if (tbCO.Text != "")
            {
                try
                {
                    co = Convert.ToDateTime(tbCO.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
                    test = false;
                }
            }
            if (tbOrder.Text != "")
            {
                try
                {
                    od = Convert.ToDateTime(tbOrder.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
                    test = false;
                }
            }
            if (tbTen.Text != "") ten = tbTen.Text;

            if (test)
            {
                stt = cbStt.SelectedIndex + 1;
                if (tbCI.Text != "") sCI = "'" + String.Format("{0:dd/MM/yyyy HH:mm}", ci) + "'";
                else sCI = "null";
                if (tbCO.Text != "") sCO = "'" + String.Format("{0:dd/MM/yyyy HH:mm}", co) + "'";
                else sCO = "null";
                if (tbOrder.Text != "") sOd = "'" + String.Format("{0:dd/MM/yyyy HH:mm}", od) + "'";
                else sOd = "null";
                string query1 = "update KhachHang set tenKH =N'" + ten + "' where IdKH='" + label7.Text + "'";
                string query11 = "set dateformat dmy";
                string query2 = "update Bill set CI=" + sCI + " where IdKH ='" + label7.Text + "'";
                string query3 = "update Bill set CO=" + sCO + " where IdKH ='" + label7.Text + "'";
                string query4 = "update Phong set TrangThai = " + stt + " where IdPhong =" + currentZoom ;
                string query5 = "update Phong set LichDat=" + sOd + " where TenPhong ='" + tbZoom.Text + "'";
                string query6 = "update Bill set HoaDon =" + ((checkBox1.Checked) ? 1 : 0).ToString() + " where IdKH = '" + label7.Text + "'";
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    SqlCommand c1 = new SqlCommand(query1, conn);
                    SqlCommand c11 = new SqlCommand(query11, conn);
                    SqlCommand c2 = new SqlCommand(query2, conn);
                    SqlCommand c3 = new SqlCommand(query3, conn);
                    SqlCommand c4 = new SqlCommand(query4, conn);
                    SqlCommand c5 = new SqlCommand(query5, conn);
                    SqlCommand c6 = new SqlCommand(query6, conn);
                    //MessageBox.Show(query2);
                    c1.ExecuteNonQuery();
                    c11.ExecuteNonQuery();
                    c2.ExecuteNonQuery();
                    c3.ExecuteNonQuery();
                    MessageBox.Show(stt.ToString());
                    c4.ExecuteNonQuery();
                    c5.ExecuteNonQuery();
                    c6.ExecuteNonQuery();
                    conn.Close();
                }

                MainForm.m.Update();
                this.Dispose();
            }
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            new DatabaseConnection().zoomResetStatus(currentZoom);
            MainForm.m.getThongTinPhong(currentZoom);
            MainForm.m.clear();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool test = true; //kiem tra cac tb da dien dung dinh dang chua
            DateTime ci = new DateTime();
            DateTime co = new DateTime();
            DateTime od = new DateTime();
            string sCI, sCO, sOd, ten = "NoName";
            string idBill = new DatabaseConnection().createNextBill();

            #region
            // var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == currentZoom)
            //    {
            //        if (tbCI.Text != "")
            //        { //Kiểm tra định dang ngày tháng nhập vào
            //            try
            //            {
            //                DateTime ci = Convert.ToDateTime(tbCI.Text);
            //                a.Cells[i + 1, 3].Value = ci.ToString();


            //            }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
            //                test = false;
            //                break;
            //            }
            //        }
            //        else a.Cells[i + 1, 3].Value = "";

            //        if (tbCO.Text != "")
            //        {
            //            try
            //            {
            //                DateTime co = Convert.ToDateTime(tbCO.Text);
            //                a.Cells[i + 1, 4].Value = co.ToString();

            //            }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
            //                test = false;
            //                break;
            //            }
            //        }
            //        else a.Cells[i + 1, 4].Value = "";

            //        if (tbOrder.Text != "")
            //        {
            //            try
            //            {
            //                DateTime od = Convert.ToDateTime(tbOrder.Text);
            //                a.Cells[i , 3].Value = od.ToString();

            //            }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
            //                test = false;
            //                break;
            //            }
            //        }
            //        else a.Cells[i, 3].Value = "";
            //        if (checkBox1.Checked) a.Cells[i, 4].Value = "Yes";
            //        else a.Cells[i, 4].Value = "No";

            //        a.Cells[i + 1, 1].Value = tbTen.Text;
            //        a.Cells[i + 2, 2].Value = cbStt.SelectedIndex + 1;

            //    }
            //}

            //if (test)
            //{
            //    Byte[] bin = package.GetAsByteArray();
            //    File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            #endregion
            if (tbCI.Text != "")
            {
                try
                {
                    ci = Convert.ToDateTime(tbCI.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
                    test = false;
                }
            }
            if (tbCO.Text != "")
            {
                try
                {
                    co = Convert.ToDateTime(tbCO.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
                    test = false;
                }
            }
            if (tbOrder.Text != "")
            {
                try
                {
                    od = Convert.ToDateTime(tbOrder.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai định dang ngày tháng. Vui lòng kiểm tra lại!");
                    test = false;
                }
            }
            if (tbTen.Text != "") ten = tbTen.Text;
            stt = cbStt.SelectedIndex + 1;

            if (test)
            {
                string dg,dv;
                int[] sZoom = { 103, 102, 201, 202, 203, 207 };
                if (sZoom.Contains(currentZoom)) { dg = "400000"; dv = "PB"; }
                else { dg = "300000"; dv = "PD"; }

                if (tbCI.Text != "") sCI = "'" + String.Format("{0:dd/MM/yyyy HH:mm}", ci) + "'";
                else sCI = "null";
                if (tbCO.Text != "") sCO = "'" + String.Format("{0:dd/MM/yyyy HH:mm}", co) + "'";
                else sCO = "null";
                if (tbOrder.Text != "") sOd = "'" + String.Format("{0:dd/MM/yyyy HH:mm}", od) + "'";
                else sOd = "null";
                string query1 = "insert into KhachHang(IdKH,TenKH) values('"+label7.Text+"',N'"+ten+"')";
                string query = "set dateformat dmy";
                string query2 = "insert into Bill(IdBill,IdKH,CI,CO,IdPhong,HoaDon) values ('" + idBill + "','"
                    + label7.Text + "'," + sCI + "," + sCO + "," + currentZoom + "," + ((checkBox1.Checked) ? 1 : 0).ToString() + ")";
                string query3 = "update Phong set LichDat ="+sOd+", TrangThai ="+stt+" ,IdBill ='"+ idBill+"' where IdPhong ="+currentZoom ;

                string query4 = "insert into BillInfo(IdBill,IdDV,DonGia) values ('" + idBill + "','" + dv + "'," + dg + ")";
                
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    SqlCommand c1 = new SqlCommand(query1, conn);
                    SqlCommand c = new SqlCommand(query, conn);
                    SqlCommand c2 = new SqlCommand(query2, conn);
                    SqlCommand c3 = new SqlCommand(query3, conn);
                    SqlCommand c4 = new SqlCommand(query4, conn);
                  
                    //MessageBox.Show(query2);
                    c1.ExecuteNonQuery();
                    c.ExecuteNonQuery();
                    c2.ExecuteNonQuery();
                    
                    c3.ExecuteNonQuery();
                    c4.ExecuteNonQuery();
                    conn.Close();
                }

                MainForm.m.Update();
                this.Dispose();
            }
        }
    }
    
}
