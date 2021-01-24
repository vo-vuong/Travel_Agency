using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
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
        public decimal? PriceSale { get; set; }
        public int Quantity { get; set; }
        public int? Views { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool Status { get; set; }
        public DateTime DateStart { get; set; }
        public string Time { get; set; }
        public string LocationStart { get; set; }
    }
}
