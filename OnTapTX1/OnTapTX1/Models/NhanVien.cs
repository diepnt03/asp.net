using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnTapTX1.Models
{
    public class NhanVien
    {
        public string manv { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public int songaylam { get; set; }
        public double luongngay { get; set; }
        public double tienluong
        {
            get
            {
                return songaylam * luongngay;
            }
        }

        public NhanVien()
        {
        }

        public NhanVien(string manv, string hoten, string daichi, int songaylam, double luongngay)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = daichi;
            this.songaylam = songaylam;
            this.luongngay = luongngay;
        }
    }
}