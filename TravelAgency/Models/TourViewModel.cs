using System;
using System.Collections.Generic;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>TourViewModel</c> class.
    /// Contains all properties of Tour entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class TourViewModel
    {
        public int IDTour { get; set; }
        public string TourName { get; set; }
        public string Description { get; set; }
        public string Shortbody { get; set; }
        public string Image { get; set; }
        public string policy { get; set; }
        public string termsProvisions { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
        public int? Views { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool Status { get; set; }
        public DateTime DateStart { get; set; }
        public string Time { get; set; }
        public string LocationStart { get; set; }
        public int? IDCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillViewModel> BILLs { get; set; }

        public virtual CategoryTourViewModel CATEGORY_TOUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentViewModel> COMMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourEvaluationViewModel> TOUREVALUATIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourSaleViewModel> TOURSALEs { get; set; }
    }
}