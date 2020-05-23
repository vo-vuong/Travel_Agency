namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALE")]
    public partial class SALE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALE()
        {
            TOURSALEs = new HashSet<TOURSALE>();
        }

        [Key]
        public int IDSale { get; set; }

        [Required]
        [StringLength(50)]
        public string SaleName { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURSALE> TOURSALEs { get; set; }
    }
}
