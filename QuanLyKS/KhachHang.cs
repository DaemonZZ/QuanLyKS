using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyKS
{
    class KhachHang
    {
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private string phong;

        public string Phong
        {
            get { return phong; }
            set { phong = value; }
        }
        private DateTime checkIn;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
        private int tong;

        public int Tong
        {
            get { return tong; }
            set { tong = value; }
        }
        private string hd;

        public string Hd
        {
            get { return hd; }
            set { hd = value; }
        }
        public KhachHang()
        {
            this.ten = "";
            this.phong = "";
            this.checkIn = new DateTime();
            this.checkOut = new DateTime();
            this.tong = 0;
            this.hd = "No";
        }
        public KhachHang(string ten, string phong, DateTime checkIn, DateTime checkOut,int tong,string hd)
        {
            this.ten = ten;
            this.phong = phong;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.tong = tong;
            this.hd = hd;
        }

    }
}
