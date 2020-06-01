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
    public partial class NoteForm : Form
    {
        string gc;

        public string Gc
        {
            get { return gc; }
            set { gc = value; }
        }
        private string currentZoom;

        public NoteForm(string s)
        {
            this.currentZoom = s;

            InitializeComponent();

            load();
        }
        public void load()
        {
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == currentZoom)
                {
                    textBox1.Text = Convert.ToString(a.Cells[i, 2].Value);
                }
            }
            Byte[] bin = package.GetAsByteArray();
            File.WriteAllBytes("CurrentCustomer.xlsx", bin);
        }
        public void addNote()
        {
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == currentZoom)
                {
                    //MessageBox.Show(i.ToString());
                    Gc = textBox1.Text;
                    a.Cells[i, 2].Value = Gc;
                }
            }


            Byte[] bin = package.GetAsByteArray();
            File.WriteAllBytes("CurrentCustomer.xlsx", bin);
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
