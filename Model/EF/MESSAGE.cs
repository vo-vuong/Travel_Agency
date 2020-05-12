namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MESSAGE")]
    public partial class MESSAGE
    {
        [Key]
        public int ma_Message { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string body { get; set; }

        public DateTime? ngayTao { get; set; }

        public int? ma_TaiKhoan { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
