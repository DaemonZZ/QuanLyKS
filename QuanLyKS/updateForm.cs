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

namespace QuanLyKS
{
    public partial class updateForm : Form
    {
        private int currentZoom;
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
            string query = "select TenKH,CI,CO,TenPhong,LichDat,TrangThai,HoaDon from KhachHang inner join Bill " +
                "on KhachHang.IdKH=bill.IdKH " +
                "inner join Phong on Bill.IdBill=Phong.IdBill " +
                "where Phong.IdPhong ="+currentZoom;
            int stt=0;
            int kh;
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using(SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        tbTen.Text = rd.GetString(0);
                        if(!rd.IsDBNull(1)) tbCI.Text = Convert.ToString(rd.GetDateTime(1));
                        if (!rd.IsDBNull(2)) tbCO.Text = Convert.ToString(rd.GetDateTime(2));
                        tbZoom.Text = rd.GetString(3);
                        if (!rd.IsDBNull(4)) tbOrder.Text = Convert.ToString(rd.GetDateTime(4));
                        stt = rd.GetInt32(5);
                        if (rd.GetBoolean(6)) checkBox1.Checked = true;
                        else checkBox1.Checked = false;
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

        public updateForm( int s)
        {
            currentZoom = s;
            InitializeComponent();
            load();
        }

        private void cbStt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStt.SelectedIndex+1)
            {
                case 1:
                    {
                        cbStt.BackColor = Color.Yellow;
                        cbStt.ForeColor = Color.Purple;
                    } break;
                case 2:
                    {
                        cbStt.BackColor = Color.Lime;
                        cbStt.ForeColor = Color.Red;
                    } break;
                case 3:
                    {
                        cbStt.BackColor = Color.Aqua;
                        cbStt.ForeColor = Color.Purple;
                    } break;
                case 4:
                    {
                        cbStt.BackColor = Color.Gray;
                        cbStt.ForeColor = Color.White;
                    } break;
                case 5:
                    {
                        cbStt.BackColor = Color.DeepPink;
                        cbStt.ForeColor = Color.BlueViolet;
                    } break;
                case 6:
                    {
                        cbStt.BackColor = Color.Red;
                        cbStt.ForeColor = Color.GreenYellow;
                    } break;
                case 7:
                    {
                        cbStt.BackColor = Color.Purple;
                        cbStt.ForeColor = Color.Lime;
                    } break;
                case 8:
                    {
                        cbStt.BackColor = Color.Orange;
                        cbStt.ForeColor = Color.Blue;
                    } break;

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

        private void button2_Click(object sender, EventArgs e)
        {
            bool test = true; //kiem tra cac tb da dien dung dinh dang chua
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
                MainForm.m.Update();
                this.Dispose();
            }
        }
    
}
