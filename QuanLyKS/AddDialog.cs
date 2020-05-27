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

namespace QuanLyKS
{
    public partial class AddDialog : Form
    {
        private string curentZoom;
        public AddDialog( string s)
        {
            this.curentZoom = s;
            InitializeComponent();
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
        //
        // Chức năng ADD
        //
        public void add()
        {
            List<ThongTinDichVu> listDV = new List<ThongTinDichVu>();
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];

            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == curentZoom)
                {
                    ///Load thong tin dich vu vao ListDV
                    if (Convert.ToString(a.Cells[i + 3, 3].Value) == "")
                    {
                        listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3, 1].Value), Convert.ToInt32(a.Cells[i + 3, 2].Value), 0));
                    }
                    else listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3, 1].Value), Convert.ToInt32(a.Cells[i + 3, 2].Value), Convert.ToInt32(a.Cells[i + 3, 3].Value)));
                    for (int j = 1; j < 9; j++)
                    {
                        if (Convert.ToString(a.Cells[i + 3 + j, 1].Value) == "") break;
                        else
                        {
                            listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3 + j, 1].Value), Convert.ToInt32(a.Cells[i + 3 + j, 2].Value), Convert.ToInt32(a.Cells[i + 3 + j, 3].Value)));
                            //MessageBox.Show(Convert.ToString(a.Cells[i + 3 + j, 3].Value));
                        }
                    }
                }
            }
            if (tbDichVu.Text != "" && tbDonGia.Text != "" && tbSoLuong.Text != "")
            {
                // Thêm 1 dịch vụ
                listDV.Add(new ThongTinDichVu(tbDichVu.Text, Convert.ToInt32(tbDonGia.Text), Convert.ToInt32(tbSoLuong.Text)));
                //Fill List  bang cac dich vu rong
                int count = listDV.Count;
                for (int i = count ; i < 10; i++)
                {
                    listDV.Add(new ThongTinDichVu());
                }
                // Ghi đè lại list về Excel

                for (int i = 1; i <= a.Dimension.End.Row; i++)
                {
                    if (Convert.ToString(a.Cells[i + 1, 2].Value) == curentZoom)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            a.Cells[i + 3 + j, 1].Value = listDV[j].Dv;
                            a.Cells[i + 3 + j, 2].Value = listDV[j].Dg;
                            a.Cells[i + 3 + j, 3].Value = listDV[j].Sl;
                        }
                    }
                }
                //
                //Lưu File
                //
                Byte[] bin = package.GetAsByteArray();
                File.WriteAllBytes("CurrentCustomer.xlsx", bin);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin trước!!");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
