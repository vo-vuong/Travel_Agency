namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>TourSaleViewModel</c> class.
    /// Contains all properties of TourSale entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class TourSaleViewModel
    {
        public int? IDSale { get; set; }
        public int? IDTour { get; set; }
        public decimal? SaleRate { get; set; }
        public bool Status { get; set; }
        public virtual SaleViewModel SALE { get; set; }
        public virtual TourViewModel TOUR { get; set; }
    }
}