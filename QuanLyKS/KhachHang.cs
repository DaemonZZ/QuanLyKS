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
        private string phong;
        private DateTime checkIn;
        private DateTime checkOut;
        public KhachHang()
        {
            this.ten = "";
            this.phong = "";
            this.checkIn = new DateTime();
            this.checkOut = new DateTime();
        }
        public KhachHang(string ten, string phong, DateTime checkIn, DateTime checkOut)
        {
            this.ten = ten;
            this.phong = phong;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

    }
}
