namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHGIATOUR")]
    public partial class DANHGIATOUR
    {
        [Key]
        [StringLength(15)]
        public string ma_DanhGia { get; set; }

        public int diemDanhGia { get; set; }

        [Column(TypeName = "ntext")]
        public string danhGia { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }

        [StringLength(15)]
        public string ma_Tour { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
