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
        public int IDMessage { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string body { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? IDAccount { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }
    }
}
