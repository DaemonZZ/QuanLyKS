using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKS
{
    class Zoom
    {
        private int idPhong;
        private string phong;
        private int status;
        public Zoom(int idPhong, string phong,int status)
        {
            this.idPhong = idPhong;
            this.phong = phong;
            this.status = status;
        }
        #region
        public string getPhong()
        {
            return phong;
        }
        public int getStatus()
        {
            return status;
        }
        public void setStatus(int status)
        {
            this.status = status;
        }
        #endregion
        

    }
       

   
        
}
