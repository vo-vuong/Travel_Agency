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
            BINHLUANs = new HashSet<BINHLUAN>();
            DANHGIATOURs = new HashSet<DANHGIATOUR>();
            TOURKHUYENMAIs = new HashSet<TOURKHUYENMAI>();
        }

        [Key]
        [StringLength(15)]
        public string ma_Tour { get; set; }

        [Required]
        [StringLength(255)]
        public string tenTour { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string moTa { get; set; }

        [Column(TypeName = "money")]
        public decimal gia { get; set; }

        public int soLuong { get; set; }

        public int? luotXem { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }

        public bool? status { get; set; }

        public DateTime? ngayDi { get; set; }

        [Required]
        [StringLength(255)]
        public string diaChiKhoiHanh { get; set; }

        [StringLength(15)]
        public string ma_Slide { get; set; }

        [StringLength(15)]
        public string ma_DoiTac { get; set; }

        [StringLength(15)]
        public string ma_DanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIATOUR> DANHGIATOURs { get; set; }

        public virtual DANHMUCTOUR DANHMUCTOUR { get; set; }

        public virtual SLIDE SLIDE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURKHUYENMAI> TOURKHUYENMAIs { get; set; }
    }
}
