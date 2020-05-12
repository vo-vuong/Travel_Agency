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
        public int ma_DanhGia { get; set; }

        public int diemDanhGia { get; set; }

        [Column(TypeName = "ntext")]
        public string danhGia { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }

        public int? ma_Tour { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
