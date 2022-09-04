namespace DoAnWinform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuoc")]
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {

        }

        [Key]
        public int idThuoc { get; set; }

        [Required]
        [StringLength(50)]
        public string TenThuoc { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiThuoc { get; set; }

        [Required]
        [StringLength(50)]
        public string DonViTinh { get; set; }

        public double DonGia { get; set; }

        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }

        

    }
}
