﻿using System;
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
    public partial class FormDanhBa : Form
    {
        List<DanhBa> db = new DatabaseConnection().getListDB();
        public FormDanhBa()
        {
            InitializeComponent();
            loadGrid();
        }
        public void loadGrid()
        {
            dataGridView1.DataSource = db;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "Ten1";
            dataGridView1.Columns[1].DataPropertyName = "SDT1";
            dataGridView1.Columns[0].HeaderText = "Tên";
            dataGridView1.Columns[1].HeaderText = "Thông tin liên lạc";
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 22);
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DanhBa> db = new DatabaseConnection().searchListDB(textBox1.Text);
            dataGridView1.DataSource = db;

        }
    }
}
