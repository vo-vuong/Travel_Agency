namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOURKHUYENMAI")]
    public partial class TOURKHUYENMAI
    {
        [StringLength(15)]
        public string ma_KhuyenMai { get; set; }

        [StringLength(15)]
        public string ma_Tour { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tiLeKM { get; set; }

        public virtual KHUYENMAI KHUYENMAI { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
