namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLIDE")]
    public partial class SLIDE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLIDE()
        {
            BAIVIETs = new HashSet<BAIVIET>();
            TOURs = new HashSet<TOUR>();
        }

        [Key]
        [StringLength(15)]
        public string ma_Slide { get; set; }

        [StringLength(255)]
        public string urlSide { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAIVIET> BAIVIETs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOUR> TOURs { get; set; }
    }
}
