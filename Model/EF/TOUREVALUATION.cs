namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOUREVALUATION")]
    public partial class TOUREVALUATION
    {
        [Key]
        public int IDEvaluation { get; set; }

        public int Point { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public int? IDTour { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
