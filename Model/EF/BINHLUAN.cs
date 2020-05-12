namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BINHLUAN")]
    public partial class BINHLUAN
    {
        [Key]
        public int ma_BinhLuan { get; set; }

        [Column("binhLuan", TypeName = "ntext")]
        [Required]
        public string binhLuan1 { get; set; }

        public DateTime? ngayTao { get; set; }

        public int? ma_TaiKhoan { get; set; }

        public int? ma_Tour { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
