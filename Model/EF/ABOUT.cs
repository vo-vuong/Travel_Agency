namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ABOUT")]
    public partial class ABOUT
    {
        [Key]
        public int ma_About { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }
    }
}
