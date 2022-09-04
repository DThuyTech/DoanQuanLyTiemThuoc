namespace DoAnWinform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? idHoaDon { get; set; }

        public int? idThuoc { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
