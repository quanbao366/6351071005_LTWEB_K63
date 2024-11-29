using _6351071005_LTWEB_K63.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_LTWeb_K63.Models
{
    public class Giohang
    {
        QLBanXeGanMayEntities1 data = new QLBanXeGanMayEntities1();
        public int iMaXe { get; set; }
        public string sTenXe { get; set; }
        public string sAnhbia { get; set; }
        public Double dDongia { get; set; }
        public int iSoluong { get; set; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }

        // Khoi tao gio hang theo Maxe duoc truyen vao voi so luong mac dinh la 1
        public Giohang(int MaXe)
        {
            iMaXe = MaXe;
            XEGANMAY xe = data.XEGANMAYs.Single(n => n.MaXe == MaXe);
            sTenXe = xe.TenXe;
            sAnhbia = xe.Anhbia;
            dDongia = double.Parse(xe.Giaban.ToString());
            iSoluong = 1;
        }
    }
}