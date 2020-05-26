using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKS
{
    class ThongTinDichVu
    {
        private string dv;
        private int dg, sl, sum;

        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public int Sl
        {
            get { return sl; }
            set { sl = value; }
        }

        public int Dg
        {
            get { return dg; }
            set { dg = value; }
        }
        public string Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        
        public ThongTinDichVu()
        {
            this.dv = "";
            this.dg = 0;
            this.sl = 0;
            this.sum = 0;
        }
        public ThongTinDichVu(string dv, int dg, int sl)
        {
            this.dv = dv;
            this.dg = dg;
            this.sl = sl;
            this.sum = dg * sl;
        }
       
    }
}
