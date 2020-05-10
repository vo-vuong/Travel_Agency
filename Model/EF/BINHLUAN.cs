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
        [StringLength(15)]
        public string ma_BinhLuan { get; set; }

        [Column("binhLuan", TypeName = "ntext")]
        [Required]
        public string binhLuan1 { get; set; }

        public DateTime? ngayTao { get; set; }

        [StringLength(15)]
        public string ma_TaiKhoan { get; set; }

        [StringLength(15)]
        public string ma_Tour { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
