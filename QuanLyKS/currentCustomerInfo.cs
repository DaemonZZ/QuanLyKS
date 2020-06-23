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
        private string CI;
        private string CO;
        private string phong;
        private string order;

        public string TenKH { get => tenKH; set => tenKH = value; }
        public string CI1 { get => CI; set => CI = value; }
        public string CO1 { get => CO; set => CO = value; }
        public string Phong { get => phong; set => phong = value; }
        public string Order { get => order; set => order = value; }

        public currentCustomerInfo(string tenKH, string cI, string cO, string phong,string order)
        {
            this.tenKH = tenKH;
            CI = cI;
            CO = cO;
            this.phong = phong;
            this.order = order;
        }
        public currentCustomerInfo()
        {

        }
        }
}
