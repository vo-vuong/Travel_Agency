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
        [StringLength(15)]
        public string ma_Message { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string body { get; set; }

        public DateTime? ngayTao { get; set; }

        [StringLength(15)]
        public string ma_TaiKhoan { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
