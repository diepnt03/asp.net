using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De2.Models
{
    public class Sanpham
    {
        public string masp { get; set; }

        public string tensanpham { get; set; }

        public int soluong { get; set; }

        public double giatien { get; set; }

        public int giamgia { get; set; }

        public double thanhtien
        {
            get
            {
                if (giamgia == 0)
                {
                    return giatien * soluong;
                }
                else
                {
                    return giatien * soluong * 0.9;
                }
            }
        }

        public Sanpham()
        {
        }

        public Sanpham(string masp, string tensanpham, int soluong, double giatien, int giamgia)
        {
            this.masp = masp;
            this.tensanpham = tensanpham;
            this.soluong = soluong;
            this.giatien = giatien;
            this.giamgia = giamgia;
        }
    }
}