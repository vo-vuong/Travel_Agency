using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.EF
{
    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            BILLs = new HashSet<BILL>();
        }

        public long ID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int IDAccount { get; set; }

        [StringLength(50)]
        public string ShipName { get; set; }

        [StringLength(50)]
        public string ShipMobile { get; set; }

        [StringLength(50)]
        public string ShipAddress { get; set; }

        [StringLength(50)]
        public string ShipEmail { get; set; }

        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }
    }
}