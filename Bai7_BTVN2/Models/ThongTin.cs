using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Bai7_BTVN2.Models
{
    public class ThongTin
    {
        [DisplayName("First Name")]
        public string ho { get; set; }
        [DisplayName("Last Name")]
        public string ten { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Password")]
        public string pass { get; set; }
        [DisplayName("City")]
        public string city { get; set; }
        [DisplayName("Gender")]
        public string gender { get; set; }
        public ThongTin() { }
        public ThongTin(string ho, string ten, string email, string pass, string city, string gender)
        {
            this.ho = ho;
            this.ten = ten;
            this.email = email;
            this.pass = pass;
            this.city = city;
            this.gender = gender;
        }
    }
}