using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKS
{
    class DanhBa
    {
        private string Ten, SDT;

        public DanhBa(string ten, string sDT)
        {
            Ten1 = ten;
            SDT1 = sDT;
        }

        public string Ten1 { get => Ten; set => Ten = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
    }
}
