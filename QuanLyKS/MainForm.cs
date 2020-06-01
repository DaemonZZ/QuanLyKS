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
        private string hoverZoom="NULL";
        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
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
            radioButton1.Text = Form1.username;
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
                            case 2: itemB.BackColor = System.Drawing.Color.Lime;
                                break;
                            case 3: itemB.BackColor = System.Drawing.Color.Aqua;
                                break;
                            case 4: itemB.BackColor = System.Drawing.Color.Gray;
                                break;
                            case 5: itemB.BackColor = System.Drawing.Color.DeepPink;
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
            
            //
            //Kiêm tra nút bấm
            //
            string t = sender.ToString();
            selectedZoom = t.Substring(t.Length - 4);
            
            getThongTinPhong();
        }
        public void getThongTinPhong()
        {
            List<ThongTinDichVu> listDV = new List<ThongTinDichVu>();
            
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


                    //
                    //Load List DV
                    //
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
                    //thiết lập tên hiển thị cột
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
        //
        //Reset thong tin phong
        //
        public void zoomResetStatus(string s)
        {
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == s)
                {
                    a.Cells[i, 2].Value = "";
                    a.Cells[i, 3].Value = "";
                    a.Cells[i + 1, 1].Value = "";
                    a.Cells[i + 1, 3].Value = "";
                    a.Cells[i + 1, 4].Value = "";
                    a.Cells[i + 3, 1].Value = "Phòng nghỉ";
                    a.Cells[i + 3, 2].Value = 0;
                    a.Cells[i + 3, 3].Value = 0;
                    for (int j = 1; j < 10; j++)
                    {
                        a.Cells[i + 3 + j, 1].Value = "";
                        a.Cells[i + 3 + j, 2].Value = 0;
                        a.Cells[i + 3 + j, 3].Value = 0;
                    }
                }
            }
            Byte[] bin = package.GetAsByteArray();
            File.WriteAllBytes("CurrentCustomer.xlsx", bin);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongTimeString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (selectedZoom != "NULL")
            {
                AddDialog a = new AddDialog(selectedZoom);
                a.ShowDialog();
                getThongTinPhong();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditDialog ed = new EditDialog(selectedZoom);
            ed.ShowDialog();
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChooseStatus(object sender, EventArgs e)
        {
            string s = sender.ToString().Substring(0,1);
            int index = Convert.ToInt16(s);
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];

            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == selectedZoom)
                {
                    
                    a.Cells[i + 2, 2].Value = index;
                }
            }
            
            if (index == 1 || index == 3 || index == 4)
            {
                DialogResult rs= MessageBox.Show("Reset dữ liệu phòng", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rs == DialogResult.Yes)
                {
                    zoomResetStatus(selectedZoom);
                }
            }
            Byte[] bin = package.GetAsByteArray();
            File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            Update();
        }

        private void Zoom_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string t = sender.ToString();
                selectedZoom = t.Substring(t.Length - 4);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //Thêm ghi chú cho phòng
        //
        private void ghiChúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == selectedZoom)
                {

                    NoteForm f = new NoteForm(selectedZoom);
                    f.ShowDialog();
                    getThongTinPhong();
                }
            }
           
        }

        

        private void button206_MouseHover(object sender, EventArgs e)
        {
            string t = sender.ToString();
           // MessageBox.Show( t.Substring(t.Length - 4));
            hoverZoom = t.Substring(t.Length - 4);
            var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            ExcelWorksheet a = package.Workbook.Worksheets[0];
            for (int i = 1; i <= a.Dimension.End.Row; i++)
            {
                if (Convert.ToString(a.Cells[i + 1, 2].Value) == hoverZoom)
                {
                    toolTip1 = new ToolTip();
                    Button v = (Button)sender;
                    toolTip1.SetToolTip(v, Convert.ToString(a.Cells[i, 2].Value));
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedZoom != "NULL")
            {
                updateForm uF = new updateForm(selectedZoom);
                uF.ShowDialog();
                getThongTinPhong();
            }
        }

    }
}
