using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS
{
    public partial class add_editNVForm : Form
    {
        NhanVien rs = new NhanVien();
        public add_editNVForm( NhanVien a,string type)
        {
            
            InitializeComponent();
            if (type == DatabaseConnection.ADD)
            {
                label.Text = "Thêm Nhân Viên";
                btnAdd.Visible = true;
            }
            else
            {
                label.Text = "Sửa Nhân Viên";
                btnEdit.Visible = true;
                tbID.ReadOnly = true;
                tbID.Text = a.MaNV1;
                tbPass.Text = a.MatKhau1;
                tbTen.Text = a.Ten;
                comboBox1.Text = a.ViTri1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            rs.Ten = tbTen.Text;
            rs.ViTri1 = comboBox1.Text;
            rs.MaNV1 = tbID.Text;
            rs.MatKhau1 = tbPass.Text;
            new DatabaseConnection().editNV(rs, DatabaseConnection.EDIT);
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            rs.Ten = tbTen.Text;
            rs.ViTri1 = comboBox1.Text;
            rs.MaNV1 = tbID.Text;
            rs.MatKhau1 = tbPass.Text;
            new DatabaseConnection().editNV(rs, DatabaseConnection.ADD);
            this.Dispose();
        }
    }
}
