namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIBAIVIET")]
    public partial class LOAIBAIVIET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIBAIVIET()
        {
            BAIVIETs = new HashSet<BAIVIET>();
        }

        [Key]
        [StringLength(15)]
        public string ma_LoaiBaiViet { get; set; }

        [Required]
        [StringLength(255)]
        public string tenLoaiBaiViet { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAIVIET> BAIVIETs { get; set; }
    }
}
