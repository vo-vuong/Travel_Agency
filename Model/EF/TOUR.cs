namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOUR")]
    public partial class TOUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOUR()
        {
            BILLs = new HashSet<BILL>();
            COMMENTs = new HashSet<COMMENT>();
            TOUREVALUATIONs = new HashSet<TOUREVALUATION>();
            TOURSALEs = new HashSet<TOURSALE>();
        }

        [Key]
        public int IDTour { get; set; }

        [Required]
        [StringLength(255)]
        public string TourName { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int? Views { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public bool Status { get; set; }

        public DateTime DateStart { get; set; }

        [Required]
        [StringLength(255)]
        public string LocationStart { get; set; }

        public int? IDCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }

        public virtual CATEGORY_TOUR CATEGORY_TOUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTs { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOUREVALUATION> TOUREVALUATIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURSALE> TOURSALEs { get; set; }
    }
}
