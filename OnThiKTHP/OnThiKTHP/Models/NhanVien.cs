namespace OnThiKTHP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [Required(ErrorMessage = "Mã nhân viên không được để trống")]
        [DisplayName("Mã nhân viên")]
        public int Manv { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [DisplayName("Họ tên")]
        [StringLength(30)]
        public string Hoten { get; set; }

        [Required(ErrorMessage = "Tuổi không được để trống")]
        [DisplayName("Tuổi")]
        public int? Tuoi { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [DisplayName("Địa chỉ")]
        [StringLength(30)]
        public string Diachi { get; set; }

        [Required(ErrorMessage = "Lương không được để trống")]
        [DisplayName("Lương")]
        public int? Luong { get; set; }

        [Required(ErrorMessage = "Mã phòng không được để trống")]
        [DisplayName("Mã phòng")]
        public int? Maphong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
