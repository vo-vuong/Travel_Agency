namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTENT")]
    public partial class CONTENT
    {
        [Key]
        public int IDContent { get; set; }

        [Required]
        [StringLength(255)]
        public string ContentName { get; set; }

        public int? IDSlide { get; set; }

        [Column(TypeName = "ntext")]
        public string body { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public bool? status { get; set; }

        public DateTime? dateShow { get; set; }

        public int? IDContentCategory { get; set; }

        public int? IDAccount { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual CONTENTCATEGORY CONTENTCATEGORY { get; set; }

        public virtual SLIDE SLIDE { get; set; }
    }
}
