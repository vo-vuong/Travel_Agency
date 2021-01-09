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
        public int IDBill { get; set; }

        public int Quantity { get; set; }

        public int? IDTour { get; set; }

        public int? IDAccount { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public bool? Status { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual TOUR TOUR { get; set; }
    }
}
