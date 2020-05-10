namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAIVIET")]
    public partial class BAIVIET
    {
        [Key]
        [StringLength(15)]
        public string ma_BaiViet { get; set; }

        [Required]
        [StringLength(255)]
        public string tenBaiViet { get; set; }

        [StringLength(15)]
        public string ma_Slide { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }

        public bool? status { get; set; }

        public DateTime? dateShow { get; set; }

        [StringLength(15)]
        public string ma_LoaiBaiViet { get; set; }

        [StringLength(15)]
        public string ma_TaiKhoan { get; set; }

        public virtual LOAIBAIVIET LOAIBAIVIET { get; set; }

        public virtual SLIDE SLIDE { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
