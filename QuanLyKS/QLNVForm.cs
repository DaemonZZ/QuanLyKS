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
    public partial class QLNVForm : Form
    {
        List<NhanVien> list;
        NhanVien selected = new NhanVien();
        public const bool VIEW = false;
        public const bool ADMIN = true;
        bool type;
        public QLNVForm(bool type)
        {
            this.type = type;
            InitializeComponent();
            load();
        }
        public void load()
        {
            list = new DatabaseConnection().getListNV();
            //List<Zoom> list = new DatabaseConnection().getListZoom();
            
            dataGridView1.DataSource = list ;
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns[0].DataPropertyName = "ten";
            dataGridView1.Columns[1].DataPropertyName = "ViTri1";
            dataGridView1.Columns[2].DataPropertyName = "MaNV1";
            dataGridView1.Columns[3].DataPropertyName = "MatKhau1";
            dataGridView1.Columns[0].HeaderText = "Tên";
            dataGridView1.Columns[1].HeaderText = "Vị trí";
            dataGridView1.Columns[2].HeaderText = "Mã NV";
            dataGridView1.Columns[3].HeaderText = "Mật Khẩu";
            if (!type)
            {
                label1.Text = "Danh Sách Nhân Viên";
                btnAdd.Visible = false;
                btnDel.Visible = false;
                btnEdit.Visible = false;
                dataGridView1.Columns.RemoveAt(3);
                btnOK.Visible = true;
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            add_editNVForm add = new add_editNVForm(new NhanVien(), DatabaseConnection.ADD);
            add.ShowDialog();
            load();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            selected.Ten = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            selected.ViTri1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            selected.MaNV1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            selected.MatKhau1 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            add_editNVForm edit = new add_editNVForm(selected,DatabaseConnection.EDIT);
            edit.ShowDialog();
            load();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            selected.Ten = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            selected.ViTri1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            selected.MaNV1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            selected.MatKhau1 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DialogResult rs= MessageBox.Show("Xóa " + selected.Ten, "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                new DatabaseConnection().delNV(selected);
                load();
            }
            else { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
