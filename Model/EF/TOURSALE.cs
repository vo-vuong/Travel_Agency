namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOURSALE")]
    public partial class TOURSALE
    {
        public int? IDSale { get; set; }

        public int? IDTour { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal? SaleRate { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Status { get; set; }

        public virtual SALE SALE { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
