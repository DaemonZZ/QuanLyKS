using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKS
{
    class Zoom
    {
        private string phong;
        private int cost;
        private int status;
        public Zoom(string phong, int cost,int status)
        {
            this.phong = phong;
            this.cost = cost;
            this.status = status;
        }
        #region
        public void setPhong(string phong)
        {
            this.phong = phong;
        }
        public string getPhong()
        {
            return phong;
        }
        public void setCost(int cost)
        {
            this.cost = cost;
        }
        public int getCost()
        {
            return cost;
        }
        public void setStatus(int status)
        {
            this.status = status;
        }
        public int getStatus()
        {
            return status;
        }
        #endregion
        

    }
       

   
        
}
