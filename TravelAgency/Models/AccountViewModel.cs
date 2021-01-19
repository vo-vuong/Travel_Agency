using System;
using System.Collections.Generic;

namespace TravelAgency.Models
{
    public class AccountViewModel
    {
        /// <summary>
        /// The main <c>AccountViewModel</c> class.
        /// Contains all properties of Account entity
        /// Author: VoXuanQuocVuong
        /// Email: vovuong1025@gmail.com
        /// Date Create: 19/01/2021
        /// </summary>
        public int IDAccount { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public bool? Grener { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }
        public string IDUserGroup { get; set; }
        public virtual UserGroupViewModel USERGROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillViewModel> BILLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentViewModel> COMMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageViewModel> MESSAGEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentViewModel> CONTENTs { get; set; }
    }
}