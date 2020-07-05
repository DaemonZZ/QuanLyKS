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
    public partial class ReportForm : Form
    {
        List<DoanhThu> ListRP = new DatabaseConnection().getListRP();
        public ReportForm()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            tbMaBC.Text = new DatabaseConnection().getCurrentReport();
            lbNV.Text = Form1.username;
            dataGridView1.DataSource = ListRP;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "Ngay";
            dataGridView1.Columns[1].DataPropertyName = "DanhMuc";
            dataGridView1.Columns[2].DataPropertyName = "Thu";
            dataGridView1.Columns[3].DataPropertyName = "Chi";
            dataGridView1.Columns[4].DataPropertyName = "Note";
            dataGridView1.Columns[0].HeaderText = "Ngày";
            dataGridView1.Columns[1].HeaderText = "Danh Mục";
            dataGridView1.Columns[2].HeaderText = "Thu";
            dataGridView1.Columns[3].HeaderText = "Chi";
            dataGridView1.Columns[4].HeaderText = "Note";
            dataGridView1.Columns.RemoveAt(5);
            dataGridView1.Columns.RemoveAt(5);
            dataGridView1.Columns.RemoveAt(5);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
