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
using System.Data.SqlClient;

namespace QuanLyKS
{
    public partial class MainForm : Form
    {
        List<Zoom> ListZoom = new DatabaseConnection().getListZoom();
        List<System.Windows.Forms.Button> B = new List<System.Windows.Forms.Button>();
        DatabaseConnection conn = new DatabaseConnection();

        private int selectedZoom = 0;
        private int hoverZoom = 0;
        private string note;
        private KhachHang info;
        public static MainForm m;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        //
        //get set
        //
        public void setSelectedZoom(int selectedZoom)
        {
            this.selectedZoom = selectedZoom;
        }
        public int getSelectedZoom()
        {
            return selectedZoom;
        }

        //
        public MainForm()
        {
            m = this;
            InitializeComponent();
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
            Update();
        }
        //
        // Hàm Update gọi cùng MainForm để cập nhập dữ liệu hiện tại từ Excel
        // 
        public void Update() //ok
        {
            radioButton1.Text = Form1.username;
            ListZoom = new DatabaseConnection().getListZoom();

            #region Sử dụng Excel - -
            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i, 1].Value) == "NewKH")
            //    {
            //        foreach (var item in ListZoom)
            //        {
            //            if (item.getPhong() == Convert.ToString(a.Cells[i + 1, 2].Value))
            //            {
            //                int n = Convert.ToInt16(a.Cells[i + 2, 2].Value);
            //                item.setStatus(n);
            //                if (Convert.ToString(a.Cells[i, 3].Value) != "")
            //                {
            //                    DateTime od = Convert.ToDateTime(a.Cells[i, 3].Value);
            //                    TimeSpan ts = od - DateTime.Now;
            //                    int t = ts.Days;
            //                    if ((t == 0 || t==1) && item.getStatus() == 1) item.setStatus(2);
            //                }

            //            }
            //        }

            //    }
            //}
            #endregion


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
                            case 1:
                                itemB.BackColor = System.Drawing.Color.Yellow;
                                break;
                            case 2:
                                itemB.BackColor = System.Drawing.Color.Lime;
                                break;
                            case 3:
                                itemB.BackColor = System.Drawing.Color.Aqua;
                                break;
                            case 4:
                                itemB.BackColor = System.Drawing.Color.Gray;
                                break;
                            case 5:
                                itemB.BackColor = System.Drawing.Color.DeepPink;
                                break;
                            case 6:
                                itemB.BackColor = System.Drawing.Color.Red;
                                break;
                            case 7:
                                itemB.BackColor = System.Drawing.Color.Purple;
                                break;
                            case 8:
                                itemB.BackColor = System.Drawing.Color.Orange;
                                break;
                        }

                    }
                }
            }


        }
        //
        //Clear Form
        //
        public void clear() //ok
        {

            setSelectedZoom(0);

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


        private void btnLogout_Click(object sender, EventArgs e) //ok
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();

        }
        //
        //Sự Kien chung khi bấm nút chọn phòng
        //
        private void Zoom_Click(object sender, EventArgs e)//ok
        {

            //
            //Kiêm tra nút bấm
            //
            string t = sender.ToString();
            selectedZoom = Convert.ToInt32(t.Substring(t.Length - 3));

            getThongTinPhong(selectedZoom);
        }
        public void getThongTinPhong(int s)//ok
        {
            string idBill = "";
            int tong = 0;
            currentCustomerInfo info = new DatabaseConnection().getCurrentInfo(s);
            tbName.Text = info.TenKH;
            tbPhong.Text = info.Phong;
            if (tbPhong.Text == "")
            {
                tbCI.Text = "";
                tbCO.Text = "";
            }
            else
            {
                tbCI.Text = Convert.ToString(info.CI1);
                tbCO.Text = Convert.ToString(info.CO1);
            }

            ListZoom = new DatabaseConnection().getListZoom();//Lấy lại thông tin phòng khi bị thay đổi

            foreach (Zoom item in ListZoom)
            {
                if (item.getIdPhong() == selectedZoom)
                {
                    idBill = item.getIdBill();
                }
            }

            List<ThongTinDichVu> listDV = new DatabaseConnection().getDV(idBill, DatabaseConnection.EDIT);
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
            if (dataGridView1.ColumnCount > 4) dataGridView1.Columns.RemoveAt(4);
            //MessageBox.Show(selectedZoom.ToString());

            foreach (ThongTinDichVu item in listDV)
            {
                tong += item.Sum;
            }

            tbTotal.Text = String.Format("{0:n0}", tong);


            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];


            ////
            ////Load thông tin từ Excel
            ////
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == selectedZoom)
            //    {
            //        tbName.Text = Convert.ToString(a.Cells[i + 1, 1].Value);
            //        tbPhong.Text = selectedZoom;
            //        tbCI.Text = Convert.ToString(a.Cells[i + 1, 3].Value);
            //        tbCO.Text = Convert.ToString(a.Cells[i + 1, 4].Value);
            //        //MessageBox.Show(Convert.ToString(a.Cells[i + 4, 3].Value));


            //        //
            //        //Load List DV
            //        //
            //        /*
            //         * Dòng đầu dịch vụ phòng luôn có. khách chưa trả thì in ra 2 ô sl và dv trông
            //         * từ dòng thứ 2 là các dịch vụ đi kem có thể có hoặc không
            //         * dùng Int32 cho giá phòng vì Int16 out of range
            //         */

            //        if (Convert.ToString(a.Cells[i + 3, 3].Value) == "")
            //        {
            //            listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3, 1].Value), Convert.ToInt32(a.Cells[i + 3, 2].Value), 0));
            //        }
            //        else listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3, 1].Value), Convert.ToInt32(a.Cells[i + 3, 2].Value), Convert.ToInt32(a.Cells[i + 3, 3].Value)));
            //        for (int j = 1; j < 9; j++)
            //        {
            //            if (Convert.ToString(a.Cells[i + 3 + j, 1].Value) == "") break;
            //            else
            //            {
            //                listDV.Add(new ThongTinDichVu(Convert.ToString(a.Cells[i + 3 + j, 1].Value), Convert.ToInt32(a.Cells[i + 3 + j, 2].Value), Convert.ToInt32(a.Cells[i + 3 + j, 3].Value)));
            //                //MessageBox.Show(Convert.ToString(a.Cells[i + 3 + j, 3].Value));
            //            }
            //        }


            //        // Tổng Phòng
            //        int tong = Convert.ToInt32(a.Cells[i + 2, 4].Value);
            //        tbTotal.Text = String.Format("{0:n0}", tong);
            //    }
            //}

        }
        //
        //Reset thong tin phong
        //


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

        private void timer1_Tick(object sender, EventArgs e)//ok
        {
            label10.Text = DateTime.Now.ToLongTimeString();
        }

        private void button18_Click(object sender, EventArgs e)//ok
        {

            //MessageBox.Show((x==v).ToString());
            if (selectedZoom != 0)
            {
                string query = "select * from Phong where IdPhong='" + selectedZoom + "'";
                Zoom phong = new Zoom();
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            phong = new Zoom(selectedZoom, rd.GetString(1), rd.GetInt32(2), "");
                            if (!rd.IsDBNull(3)) phong.setIdBill(rd.GetString(3));
                        }
                    }
                    conn.Close();
                }
                if (phong.getIdBill() != "")
                {
                    AddDialog a = new AddDialog(selectedZoom);
                    a.ShowDialog();
                    getThongTinPhong(selectedZoom);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//ok
        {

            if (selectedZoom != 0)
            {
                string query = "select * from Phong where IdPhong='" + selectedZoom + "'";
                Zoom phong = new Zoom();
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            phong = new Zoom(selectedZoom, rd.GetString(1), rd.GetInt32(2), "");
                            if (!rd.IsDBNull(3)) phong.setIdBill(rd.GetString(3));
                        }
                    }
                    conn.Close();
                }
                if (phong.getIdBill() != "")
                {
                    EditDialog ed = new EditDialog(selectedZoom, dataGridView1.SelectedRows[0].Index);
                    ed.ShowDialog();
                    getThongTinPhong(selectedZoom);
                }
            }
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)//ok
        {
            Application.Exit();
        }

        private void ChooseStatus(object sender, EventArgs e)//ok
        {
            string s = sender.ToString().Substring(0, 1); // s = 1-->8
            int index = Convert.ToInt16(s);
            string query = "update Phong set TrangThai =" + index + " where IdPhong=" + selectedZoom;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            ListZoom = new DatabaseConnection().getListZoom();
            #region Excel
            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];

            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == selectedZoom)
            //    {

            //        a.Cells[i + 2, 2].Value = index;
            //        if (Convert.ToString(a.Cells[i, 3].Value) != "")
            //        {
            //            DateTime od = Convert.ToDateTime(a.Cells[i, 3].Value);
            //            TimeSpan ts = od - DateTime.Now;
            //            int t = ts.Days;
            //            if ((t == 0||t==1) && index == 1)
            //            {
            //                a.Cells[i + 2, 2].Value = 2;
            //                MessageBox.Show("Phòng này đã được đặt trong ngày.\nVui lòng không bán!");
            //            }
            //            else if (index == 1 || index == 3 || index == 4)
            //            {
            //                DialogResult rs = MessageBox.Show("Reset dữ liệu phòng", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //                if (rs == DialogResult.Yes)
            //                {
            //                    zoomResetStatus(selectedZoom);
            //                }
            //            }

            //        }
            //    }
            //}


            //Byte[] bin = package.GetAsByteArray();
            //File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            #endregion
            Update();
        }

        private void Zoom_MouseUp(object sender, MouseEventArgs e)//ok
        {
            if (e.Button == MouseButtons.Right)
            {
                string t = sender.ToString();
                selectedZoom = Convert.ToInt32(t.Substring(t.Length - 3));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)//ok
        {
            Application.Exit();
        }
        //
        //Thêm ghi chú cho phòng
        //
        private void ghiChúToolStripMenuItem_Click(object sender, EventArgs e)//Ok
        {
            //var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //ExcelWorksheet a = package.Workbook.Worksheets[0];
            //for (int i = 1; i <= a.Dimension.End.Row; i++)
            //{
            //    if (Convert.ToString(a.Cells[i + 1, 2].Value) == selectedZoom)
            //    {

            //        NoteForm f = new NoteForm(selectedZoom);
            //        f.ShowDialog();
            //        getThongTinPhong();
            //    }
            //}
            NoteForm f = new NoteForm(selectedZoom);
            f.ShowDialog();
            getThongTinPhong(selectedZoom);
        }



        private void button206_MouseHover(object sender, EventArgs e)//OK
        {
            string t = sender.ToString();
            // MessageBox.Show( t.Substring(t.Length - 4));
            hoverZoom = Convert.ToInt32(t.Substring(t.Length - 3));
            #region Excel
            // var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            // ExcelWorksheet a = package.Workbook.Worksheets[0];
            // for (int i = 1; i <= a.Dimension.End.Row; i++)
            // {
            //     if (Convert.ToString(a.Cells[i + 1, 2].Value) == hoverZoom)
            //     {
            //         toolTip1 = new ToolTip();
            //         Button v = (Button)sender;
            //         toolTip1.SetToolTip(v, Convert.ToString(a.Cells[i, 2].Value));
            //     }
            // }
            #endregion
            toolTip1.SetToolTip(sender as Button, conn.getNoteOfZoom(hoverZoom));
        }

        private void btnEdit_Click(object sender, EventArgs e)//ok??
        {
            #region Excel
            //if (selectedZoom != "NULL")
            //{
            //    var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //    ExcelWorksheet a = package.Workbook.Worksheets[0];
            //    for (int i = 1; i <= a.Dimension.End.Row; i++)
            //    {
            //        if (Convert.ToString(a.Cells[i + 1, 2].Value) == selectedZoom && Convert.ToString(a.Cells[i,3].Value)!="")
            //        {
            //            DateTime od = Convert.ToDateTime(a.Cells[i, 3].Value);
            //            TimeSpan ts = od - DateTime.Now;
            //            int t = ts.Days;
            //            if (t > 1) MessageBox.Show("Phòng này đã được đặt trước vào ngày " + od + "\n Chỉ bán " + (t-1) + " đêm!");
            //            else if (t == 0|| t==1) MessageBox.Show("Phòng này đã được đặt trong ngày.\nVui lòng không bán!");
            //            else a.Cells[i, 3].Value = "";

            //        }
            //    }
            //    Byte[] bin = package.GetAsByteArray();
            //    File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            //    updateForm uF = new updateForm(selectedZoom);
            //    uF.ShowDialog();
            //    getThongTinPhong();
            //}
            #endregion
            bool isUsing = false;
            if (selectedZoom != 0)
            {
                foreach (Zoom item in ListZoom)
                {
                    if (item.getIdPhong() == selectedZoom) isUsing = (item.getIdBill() != "");
                }
                if (isUsing)
                {
                    updateForm uF = new updateForm(selectedZoom, updateForm.EDIT);
                    uF.ShowDialog();
                    getThongTinPhong(selectedZoom);

                }
                else
                {
                    updateForm uF = new updateForm(selectedZoom, updateForm.ADD);
                    uF.ShowDialog();
                    getThongTinPhong(selectedZoom);
                }
            }
        }

        //Tra Phong
        private void button19_Click(object sender, EventArgs e)//Chưa sửa
        {
            bool dv = true, tt = true;
            
            if (selectedZoom != 0)
            {
                if (tbCI.Text == "") tt = false;
                List<ThongTinDichVu> ListDV = new DatabaseConnection().getDV(conn.getIDBill(selectedZoom),DatabaseConnection.EDIT);
                foreach (ThongTinDichVu item in ListDV)
                {
                    if (item.Dg * item.Sl == 0) tt = false;
                }
                if(!tt)
                {
                    MessageBox.Show("Điền đầy đủ thông tin khách hàng trước khi thanh toán");
                    updateForm uF = new updateForm(selectedZoom, updateForm.EDIT);
                    uF.ShowDialog();
                    getThongTinPhong(selectedZoom);
                }
                if (!dv)
                {
                    MessageBox.Show("Hoàn thanh thông tin dịch vụ trước");
                   
                }
                if (tt && dv)
                {
                    if (tbCO.Text == "") tbCO.Text = (DateTime.Now).ToString();
                    
                }

            }

            #region
            //{
            //    var package = new ExcelPackage(new FileInfo("CurrentCustomer.xlsx"));
            //    ExcelWorksheet a = package.Workbook.Worksheets[0];


            //    for (int i = 1; i <= a.Dimension.End.Row; i++)
            //    {
            //        if (Convert.ToString(a.Cells[i + 1, 2].Value) == selectedZoom)
            //        {
            //            DateTime co = new DateTime();
            //            if (Convert.ToString(a.Cells[i + 1, 4].Value) == "")
            //            {
            //                co = DateTime.Now;
            //            }
            //            else co = Convert.ToDateTime(a.Cells[i + 1, 4].Value);

            //            if (Convert.ToString(a.Cells[i + 1, 3].Value) == "")
            //            {
            //                MessageBox.Show("Cập nhập đầy đủ thông tin khách hàng trước");
            //                btnEdit.PerformClick();
            //            }
            //            else
            //            {
            //                info = new KhachHang(Convert.ToString(a.Cells[i + 1, 1].Value), Convert.ToString(a.Cells[i + 1, 2].Value), Convert.ToDateTime(a.Cells[i + 1, 3].Value), co, Convert.ToInt32(a.Cells[i + 2, 4].Value), Convert.ToString(a.Cells[i,4].Value));
            //                if (info.Ten == "") info.Ten = "NoName";
            //                a.Cells[i, 2].Value = "";
            //                a.Cells[i + 1, 1].Value = "";
            //                a.Cells[i + 1, 3].Value = "";
            //                a.Cells[i + 1, 4].Value = "";
            //                a.Cells[i + 2, 2].Value = 3;
            //                a.Cells[i + 3, 2].Value = 0;
            //                a.Cells[i + 3, 3].Value = 0;
            //                for (int n = 1; n < 9; n++)
            //                {
            //                    a.Cells[i + 3 + n, 3].Value = 0;
            //                    a.Cells[i + 3 + n, 2].Value = 0;
            //                    a.Cells[i + 3 + n, 1].Value = "";
            //                }
            //                Byte[] bin = package.GetAsByteArray();
            //                File.WriteAllBytes("CurrentCustomer.xlsx", bin);
            //            }
            //            Hoanthientt subform = new Hoanthientt(selectedZoom);
            //            subform.Show();
            //            LuuTru();

            //        }
            //    }


            //    getThongTinPhong();
            //    Update();
            //}
            #endregion
        }
        public void LuuTru()//Chưa sửa
        {
            //var save = new ExcelPackage(new FileInfo("CustomerLog.xlsx"));
            //ExcelWorksheet b = save.Workbook.Worksheets[0];
            //int i = b.Dimension.End.Row + 1;
            //b.Cells[i, 1].Value = info.Ten;
            //b.Cells[i, 2].Value = info.Phong;
            //b.Cells[i, 3].Value = Convert.ToString(info.CheckIn);
            //b.Cells[i, 4].Value = Convert.ToString(info.CheckOut);
            //b.Cells[i, 5].Value = Convert.ToString(info.Tong);
            //b.Cells[i, 6].Value = info.Hd; 
            //Byte[] bin2 = save.GetAsByteArray();
            //File.WriteAllBytes("CustomerLog.xlsx", bin2);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ReportForm rp = new ReportForm();
            rp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhBa db = new DanhBa();
            db.ShowDialog();
        }

        private void gửiBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm rp = new ReportForm();
            rp.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
        }

    }
}
