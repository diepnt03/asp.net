namespace OnTapTX2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Danhmuc")]
    public partial class Danhmuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Danhmuc()
        {
            Trangsucs = new HashSet<Trangsuc>();
        }

        [Key]
        [Required(ErrorMessage = "Mã danh mục không được để trống")]
        [DisplayName("Mã danh mục")]
        public int MaDanhmuc { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [DisplayName("Tên danh mục")]
        [StringLength(50)]
        public string TenDanhmuc { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống")]
        [DisplayName("Mô tả")]
        [StringLength(100)]
        public string Mota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trangsuc> Trangsucs { get; set; }
    }
}
