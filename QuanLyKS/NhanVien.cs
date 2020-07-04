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

        public string Ten { get => ten; set => ten = value; }
        public string ViTri1 { get => ViTri; set => ViTri = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        #region Phương Thức getter setter
        public void setTen(string ten)
        {
            this.Ten = ten;
        }
        public string getTen()
        {
            return Ten;
        }
        public void setViTri(string ViTri)
        {
            this.ViTri1 = ViTri;
        }
        public string getViTri()
        {
            return ViTri1;
        }
        public void setMaNV(string MaNV)
        {
            this.MaNV1 = MaNV;
        }
        public string getMaNV()
        {
            return MaNV1;
        }
        public void setMatKhau(string MatKhau)
        {
            this.MatKhau1 = MatKhau;
        }
        public string getMatKhau()
        {
            return MatKhau1;
        }
        #endregion

        public NhanVien()
        {
            this.Ten = "";
            this.ViTri1 = "";
            this.MaNV1 = "";
            this.MatKhau1 = "";
        }
        public NhanVien(string ten,string ViTri,string MaNV,string MatKhau)
        {
            this.Ten = ten;
            this.ViTri1 = ViTri;
            this.MaNV1 = MaNV;
            this.MatKhau1 = MatKhau;
        }
    }
}
