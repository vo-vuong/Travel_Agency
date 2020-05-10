namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUYENMAI")]
    public partial class KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYENMAI()
        {
            TOURKHUYENMAIs = new HashSet<TOURKHUYENMAI>();
        }

        [Key]
        [StringLength(15)]
        public string ma_KhuyenMai { get; set; }

        [Required]
        [StringLength(50)]
        public string tenKhuyenMai { get; set; }

        public DateTime? ngayBatDau { get; set; }

        public DateTime ngayKetThuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURKHUYENMAI> TOURKHUYENMAIs { get; set; }
    }
}
