namespace DoAnWinform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Column("TaiKhoan")]
        [Required]
        [StringLength(50)]
        public string TaiKhoan1 { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        public bool isAdmin { get; set; }

        public bool TrangThai { get; set; }
    }
}
