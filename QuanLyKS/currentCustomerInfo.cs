using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKS
{
    class currentCustomerInfo
    {
        private string tenKH;
        private DateTime CI;
        private DateTime CO;
        private string phong;

        public string TenKH { get => tenKH; set => tenKH = value; }
        public DateTime CI1 { get => CI; set => CI = value; }
        public DateTime CO1 { get => CO; set => CO = value; }
        public string Phong { get => phong; set => phong = value; }

        public currentCustomerInfo(string tenKH, DateTime cI, DateTime cO, string phong)
        {
            this.tenKH = tenKH;
            CI = cI;
            CO = cO;
            this.phong = phong;
        }
        public currentCustomerInfo()
        {

        }
        }
}
