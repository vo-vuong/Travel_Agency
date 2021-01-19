using System;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>BillViewModel</c> class.
    /// Contains all properties of Bill entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class BillViewModel
    {
        public int IDBill { get; set; }
        public int Quantity { get; set; }
        public int? IDTour { get; set; }
        public int? IDAccount { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? Status { get; set; }
        public virtual AccountViewModel ACCOUNT { get; set; }
        public virtual TourViewModel TOUR { get; set; }
    }
}