using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyKS
{
    class KhachHang
    {
        private string id, ten, cmnd;

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public KhachHang(string id, string ten, string cmnd)
        {
            this.id = id;
            this.ten = ten;
            this.cmnd = cmnd;
        }

    }
}
