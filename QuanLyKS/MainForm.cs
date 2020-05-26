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
        
        private string selectedZoom = "NULL";
        //
        //get set
        //
        public void setSelectedZoom(string selectedZoom)
        {
            this.selectedZoom = selectedZoom;
        }
        public string getSelectedZoom()
        {
            return selectedZoom;
        }
        //
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
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i, 1].Value) == "NewKH")
                {
                    foreach (var item in ListZoom)
                    {
                        if (item.getPhong() == Convert.ToString(a.Cells[i + 1, 2].Value))
                        {
                            int n = Convert.ToInt16(a.Cells[i + 2, 2].Value);
                            item.setStatus(n);
                        }
                    }

                }
            }

            /*Trạng thái Phòng
             * 1. Phòng Sạch
             * 2. Phòng Có khách đặt trước trong ngày - không bán
             * 3. Phòng vừa trả chưa sử dụng đc
             * 4. Phòng trong thời gian bảo trì - không bán
             * 5. Phòng đang có khách ở
             * 6-7-8. Gộp nhiều phòng cùng màu biểu thị khách đi theo đoàn thuê nhiều phòng
             */
            foreach (var itemB in B)
            {
                foreach (var itemZ in ListZoom)
                {
                    if (itemB.Text == itemZ.getPhong())
                    {
                        switch (itemZ.getStatus())
                        {
                            case 1: itemB.BackColor = System.Drawing.Color.Yellow;
                                break;
                            case 2: itemB.BackColor = System.Drawing.Color.Green;
                                break;
                            case 3: itemB.BackColor = System.Drawing.Color.Aqua;
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
        //
        //Clear Form
        //
        public void clear()
        {
            
            setSelectedZoom("NULL");

            tbName.Text = "";
            tbPhong.Text = "";
            tbCI.Text = "";
            tbCO.Text = "";
            //Xoá bảng
            dataGridView1.DataSource = new List<ThongTinDichVu>();
            
            dataGridView1.Columns[0].HeaderText = "Dịch Vụ";
            dataGridView1.Columns[1].HeaderText = "Đơn Giá";
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].HeaderText = "Tổng";

        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();

        }
        //
        //Sự Kien chung khi bấm nút chọn phòng
        //
        private void Zoom_Click(object sender, EventArgs e)
        {
            List<ThongTinDichVu> listDV = new List<ThongTinDichVu>();
            //
            //Kiêm tra nút bấm
            //
            string t = sender.ToString();
            selectedZoom = t.Substring(t.Length - 4);
            //MessageBox.Show(selectedZoom);

            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];


            //
            //Load thông tin từ Excel
            //
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == selectedZoom)
                {
                    tbName.Text = Convert.ToString(a.Cells[i + 1, 1].Value);
                    tbPhong.Text = selectedZoom;
                    tbCI.Text = Convert.ToString(a.Cells[i + 1, 3].Value);
                    tbCO.Text = Convert.ToString(a.Cells[i + 1, 4].Value);
                    //MessageBox.Show(Convert.ToString(a.Cells[i + 4, 3].Value));

                    /*
                     * Dòng đầu dịch vụ phòng luôn có. khách chưa trả thì in ra 2 ô sl và dv trông
                     * từ dòng thứ 2 là các dịch vụ đi kem có thể có hoặc không
                     * dùng Int32 cho giá phòng vì Int16 out of range
                     */

                    if (Convert.ToString(a.Cells[i + 3, 3].Value) == "")
                    {
                        listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3, 1].Value), Convert.ToInt32(a.Cells[i + 3, 2].Value), 0));
                    }
                    else listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3, 1].Value), Convert.ToInt32(a.Cells[i + 3, 2].Value), Convert.ToInt32(a.Cells[i + 3, 3].Value)));
                    for (int j = 1; j < 9; j++)
                    {
                        if (Convert.ToString(a.Cells[i + 3 + j, 1].Value) == "") break;
                        else
                        {
                            listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3 + j, 1].Value), Convert.ToInt32(a.Cells[i + 3 + j, 2].Value), Convert.ToInt32(a.Cells[i + 3 + j, 3].Value)));
                            //MessageBox.Show(Convert.ToString(a.Cells[i + 3 + j, 3].Value));
                        }
                    }
                    
                    dataGridView1.DataSource = listDV;
                    dataGridView1.AutoGenerateColumns = false;
                    // Thiết lập vị trí cột
                    dataGridView1.Columns[0].DataPropertyName = "dv";
                    dataGridView1.Columns[1].DataPropertyName = "dg";
                    dataGridView1.Columns[2].DataPropertyName = "sl";
                    dataGridView1.Columns[3].DataPropertyName = "sum";
                    //thiết lập tên hiển thị cộtk
                    dataGridView1.Columns[0].HeaderText = "Dịch Vụ";
                    dataGridView1.Columns[1].HeaderText = "Đơn Giá";
                    dataGridView1.Columns[2].HeaderText = "Số Lượng";
                    dataGridView1.Columns[3].HeaderText = "Tổng";
                    // Tổng Phòng
                    int tong = Convert.ToInt32(a.Cells[i + 2, 4].Value);
                    tbTotal.Text = String.Format("{0:n0}", tong);
                }
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #region

        // xoá tất cả thông tin hiển thị khi bấm ra ngoài vùng Phòng

        private void MainForm_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            clear();
        }
        #endregion
       
        
    }
}
