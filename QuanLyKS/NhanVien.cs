using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKS
{
    public class NhanVien
    {
        private string ten;
        private string ViTri;
        private string MaNV;
        private string MatKhau;
        #region Phương Thức getter setter
        public void setTen(string ten)
        {
            this.ten = ten;
        }
        public string getTen()
        {
            return ten;
        }
        public void setViTri(string ViTri)
        {
            this.ViTri = ViTri;
        }
        public string getViTri()
        {
            return ViTri;
        }
        public void setMaNV(string MaNV)
        {
            this.MaNV = MaNV;
        }
        public string getMaNV()
        {
            return MaNV;
        }
        public void setMatKhau(string MatKhau)
        {
            this.MatKhau = MatKhau;
        }
        public string getMatKhau()
        {
            return MatKhau;
        }
        #endregion

        public NhanVien()
        {
            this.ten = "";
            this.ViTri = "";
            this.MaNV = "";
            this.MatKhau = "";
        }
        public NhanVien(string ten,string ViTri,string MaNV,string MatKhau)
        {
            this.ten = ten;
            this.ViTri = ViTri;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
        }
    }
}
