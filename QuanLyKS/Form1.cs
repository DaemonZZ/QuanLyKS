using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKS
{
    public partial class Form1 : Form
    {
        private string query = @"select * from NhanVien ";
        private string password;

        //
        // Phương thức get set
        //
        #region
        public void setQuery(string query)
        {
            this.query = query;
        }
        public string getQuery()
        {
            return query;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
        #endregion 


        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(ConnectionString.excelConnectionString);
        }

        DataTable loadComboBox()
        {
            
            DataTable data = new DataTable();
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString)){
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        void loadPassword()
        {
            string sql = @"select MatKhau from NhanVien where MaNV = N'"+comboBox2.Text+"'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd  = new SqlCommand(sql,conn);
               // cmd.Parameters.AddWithValue("@id", comboBox2.Text);
               // SqlDataAdapter adt = new SqlDataAdapter(cmd);
                password = (string)cmd.ExecuteScalar();
                conn.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            setQuery(@"select * from NhanVien where ViTri=N'" + comboBox1.Text + "'");
            try
            {
                    comboBox2.DisplayMember = "MaNV";
                    comboBox2.DataSource = loadComboBox();
            }
            catch (Exception k) { }
            
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loadPassword();
            if (tbPass.Text == password)
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
        }
               
        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
