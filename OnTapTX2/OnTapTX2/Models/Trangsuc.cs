namespace OnTapTX2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trangsuc")]
    public partial class Trangsuc
    {
        [Key]
        [Required(ErrorMessage = "Mã trang sức không được để trống")]
        [DisplayName("Mã trang sức")]
        public int MaTs { get; set; }

        [Required(ErrorMessage = "Tên trang sức không được để trống")]
        [DisplayName("Tên trang sức")]
        [StringLength(100)]
        public string TenTs { get; set; }

        [DisplayName("Hình ảnh")]
        [StringLength(250)]
        public string Anh { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống")]
        [DisplayName("Mô tả")]
        [StringLength(250)]
        public string Mota { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống")]
        [DisplayName("Số lượng")]
        public int? Soluong { get; set; }

        [Required(ErrorMessage = "Giá tiền không được để trống")]
        [DisplayName("Giá tiền")]
        public decimal Giatien { get; set; }

        [DisplayName("Mã danh mục")]
        public int MaDanhmuc { get; set; }

        public virtual Danhmuc Danhmuc { get; set; }
    }
}
