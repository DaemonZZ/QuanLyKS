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
    public partial class Hoanthientt : Form
    {
        private string currentZoom;
        public Hoanthientt( string s)
        {
            currentZoom = s;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var package = new ExcelPackage(new FileInfo("CustomerLog.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];


            a.Cells[a.Dimension.End.Row, 7].Value = textBox1.Text;
            Byte[] bin = package.GetAsByteArray();
            File.WriteAllBytes("CustomerLog.xlsx", bin);

           

            this.Dispose();
        }
    }
}
