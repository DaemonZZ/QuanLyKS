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
    public partial class AddDanhBaForm : Form
    {
        public AddDanhBaForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                new DatabaseConnection().addDanhBa(textBox1.Text, textBox2.Text);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Nhập thông tin");
            }
        }
    }
}
