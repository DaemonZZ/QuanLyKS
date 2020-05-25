using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
namespace QuanLyKS
{
    public partial class MainForm : Form
    {
        List<Zoom> ListZoom = new DatabaseConnection().getListZoom();
        List<System.Windows.Forms.Button> B = new List<System.Windows.Forms.Button>();
        public MainForm()
        {
            InitializeComponent();
            Update();
        }
        //
        // Hàm Update gọi cùng MainForm để cập nhập dữ liệu hiện tại từ Excel
        // 
        public void Update()
        {
            
            B.Add(button101);
            B.Add(button102);
            B.Add(button103);
            B.Add(button104);
            B.Add(button105);
            B.Add(button106);
            B.Add(button107);
            B.Add(button108);
            B.Add(button201);
            B.Add(button202);
            B.Add(button203);
            B.Add(button204);
            B.Add(button205);
            B.Add(button206);
            B.Add(button207);
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            //string s = a.Cells[3, 2].Value.ToString(); int n = Int16.Parse(s);
           // textBox1.Text = (a.Dimension.Start.Row).ToString();
            for (int i=1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i,1].Value) == "NewKH")
                {
                    foreach (var item in ListZoom)
                    {
                        if (item.getPhong() == Convert.ToString(a.Cells[i + 1, 2].Value))
                        {
                            int n = Convert.ToInt16(a.Cells[i + 2, 2].Value);
                            item.setStatus(n);
                            //MessageBox.Show("Set Status ok");
                        }
                    }
                    
                }
            }
            foreach (var itemB in B)
            {
                foreach (var itemZ  in ListZoom)
                {
                    if (itemB.Text == itemZ.getPhong())
                    {
                        switch (itemZ.getStatus())
                        {
                            case 1: itemB.BackColor = System.Drawing.Color.Yellow;
                                break;
                            case 2: itemB.BackColor = System.Drawing.Color.Green;
                                break;
                            case 3: itemB.BackColor = System.Drawing.Color.LightBlue;
                                break;
                            case 4: itemB.BackColor = System.Drawing.Color.Gray;
                                break;
                            case 5: itemB.BackColor = System.Drawing.Color.Tomato;
                                break;
                            case 6: itemB.BackColor = System.Drawing.Color.Red;
                                break;
                            case 7: itemB.BackColor = System.Drawing.Color.Purple;
                                break;
                            case 8: itemB.BackColor = System.Drawing.Color.Orange;
                                break;
                        }
                    }
                }
            }


        }
       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
            
        }

        private void Zoom_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }
    }
}
