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
        private string idBill;
        private string note;
        public Zoom(int idPhong, string phong,int status,string idBill)
        {
            this.idPhong = idPhong;
            this.phong = phong;
            this.status = status;
            this.idBill = idBill;
        }

        public Zoom()
        {
            this.idPhong = 0;
            this.phong = "";
            this.status = 0;
            this.idBill = "";
        }

        public Zoom(int idPhong, string phong, int status, string idBill, string note) : this(idPhong, phong, status, idBill)
        {
            this.note = note;
        }


        #region
        public int getIdPhong()
        {
            return idPhong;
        }
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
        public string getIdBill()
        {
            return idBill;
        }
        public void setIdBill(string idBill)
        {
            this.idBill = idBill;
        }
        public void setNote(string note)
        {
            this.note = note;
        }
        public string getNote()
        {
            return note;
        }

    }
       

   
        
}
