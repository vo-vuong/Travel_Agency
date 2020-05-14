namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOAN()
        {
            BAIVIETs = new HashSet<BAIVIET>();
            BILLs = new HashSet<BILL>();
            BINHLUANs = new HashSet<BINHLUAN>();
            MESSAGEs = new HashSet<MESSAGE>();
        }

        [Key]
        public int ma_TaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string tenTaiKhoan { get; set; }

        public int ma_Nhom { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string matKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string hoTen { get; set; }

        [StringLength(255)]
        public string diaChi { get; set; }

        [StringLength(15)]
        public string dienThoai { get; set; }

        public DateTime? ngaySinh { get; set; }

        public bool? gioiTinh { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }

        public bool? status { get; set; }

        [StringLength(255)]
        public string hinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAIVIET> BAIVIETs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MESSAGE> MESSAGEs { get; set; }
    }
}
