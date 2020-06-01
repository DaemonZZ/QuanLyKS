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

namespace QuanLyKS
{
    public partial class EditDialog : Form
    {
        private int n;
        private string curentZoom;
        public EditDialog(string s,int index)
        {
            n = index;
            this.curentZoom = s;
            InitializeComponent();
            load();
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
        public void load()
        {
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == curentZoom)
                {
                    tbDichVu.Text = Convert.ToString(a.Cells[i + 3+n, 1].Value);
                    tbDonGia.Text = Convert.ToString(a.Cells[i + 3+n, 2].Value);
                    tbSoLuong.Text = Convert.ToString(a.Cells[i + 3+n, 3].Value);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == curentZoom)
                {
                    a.Cells[i + 3 + n, 1].Value = tbDichVu.Text;
                    a.Cells[i + 3 + n, 2].Value = tbDonGia.Text;
                    a.Cells[i + 3 + n, 3].Value = tbSoLuong.Text;
                }
            }
            Byte[] bin = package.GetAsByteArray();
            File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            this.Dispose();
        }
    }
}
