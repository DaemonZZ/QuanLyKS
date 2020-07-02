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
    public partial class NoteForm : Form
    {
        private int currentZoom;

        public NoteForm(int s)
        {
            this.currentZoom = s;

            InitializeComponent();
            load();
        }
        public void load()
        {
            #region Excel
            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == currentZoom)
            //    {
            //        textBox1.Text = Convert.ToString(a.Cells[i, 2].Value);
            //    }
            //}
            //Byte[] bin = package.GetAsByteArray();
            //File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            #endregion
            textBox1.Text = new DatabaseConnection().getNoteOfZoom(currentZoom);

        }
        public void addNote()
        {
            #region Excel
            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == currentZoom)
            //    {
            //        //MessageBox.Show(i.ToString());
            //        Gc = textBox1.Text;
            //        a.Cells[i, 2].Value = Gc;
            //    }
            //}


            //Byte[] bin = package.GetAsByteArray();
            //File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            #endregion
            string text = "null";
            if (textBox1.Text != "") text = "N'"+textBox1.Text+"'";
            string query = "update phong set Note = " + text+" where IdPhong="+currentZoom;
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            this.Dispose();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            addNote();
        }
    }
}
