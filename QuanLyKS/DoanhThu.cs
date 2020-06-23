using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKS
{
    class DoanhThu
    {
        private DateTime ngay;
        private string idBill;
        private string maNV;
        private string danhMuc;
        private int thu;
        private int chi;
        private string note;

        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string IdBill { get => idBill; set => idBill = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
        public int Thu { get => thu; set => thu = value; }
        public int Chi { get => chi; set => chi = value; }
        public string Note { get => note; set => note = value; }

        public DoanhThu()
        {
            this.Ngay = DateTime.Now;
            this.IdBill = "";
            this.MaNV = "";
            this.DanhMuc = "";
            this.Thu = 0;
            this.Chi = 0;
            this.Note = "";
        }

        public DoanhThu(DateTime ngay, string idBill, string maNV, string danhMuc, int thu, int chi, string note)
        {
            this.Ngay = ngay;
            this.IdBill = idBill;
            this.MaNV = maNV;
            this.DanhMuc = danhMuc;
            this.Thu = thu;
            this.Chi = chi;
            this.Note = note;
        }

        public DoanhThu(DateTime ngay, string maNV, string danhMuc, int thu, int chi, string note)
        {
            this.Ngay = ngay;
            this.MaNV = maNV;
            this.DanhMuc = danhMuc;
            this.Thu = thu;
            this.Chi = chi;
            this.Note = note;
        }
    }
}
