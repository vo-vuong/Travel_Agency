namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMENT")]
    public partial class COMMENT
    {
        [Key]
        public int IDComment { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string content { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? IDAccount { get; set; }

        public int? IDTour { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
