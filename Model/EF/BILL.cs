namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BILL")]
    public partial class BILL
    {
        [Key]
        public int ma_Bill { get; set; }

        public int soLuong { get; set; }

        public int? ma_Tour { get; set; }

        public int? ma_TaiKhoan { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }

        public bool? status { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
