using System.Collections.Generic;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>CategoryTourViewModel</c> class.
    /// Contains all properties of Categorytour entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class CategoryTourViewModel
    {
        public int IDCategory { get; set; }
        public string CategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourViewModel> TOURs { get; set; }
    }
}