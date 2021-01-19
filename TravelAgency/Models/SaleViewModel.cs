using System;
using System.Collections.Generic;

namespace TravelAgency.Models
{
    public class SaleViewModel
    {
        public int IDSale { get; set; }
        public string SaleName { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourSaleViewModel> TOURSALEs { get; set; }
    }
}