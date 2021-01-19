using System.Collections.Generic;

namespace TravelAgency.Models
{
    public class UserGroupViewModel
    {
        public string IDUserGroup { get; set; }
        public string GroupName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountViewModel> ACCOUNTs { get; set; }
    }
}