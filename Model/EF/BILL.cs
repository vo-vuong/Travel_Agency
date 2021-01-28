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

        public long? IDOrder { get; set; }

        public virtual TOUR TOUR { get; set; }

        public virtual Order Order { get; set; }
    }
}
