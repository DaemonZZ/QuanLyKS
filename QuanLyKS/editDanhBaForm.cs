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
    public partial class editDanhBaForm : Form
    {
        string ten = "", sdt = "";
        public editDanhBaForm(string ten,string sdt)
        {
            this.ten = ten;
            this.sdt = sdt;
            InitializeComponent();
            textBox1.Text = ten;
            textBox2.Text = sdt;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                new DatabaseConnection().editDanhBa(ten, textBox2.Text);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
