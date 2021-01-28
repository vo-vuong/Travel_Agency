using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgency.Models
{
    public class CartItemModel
    {
        public Model.ViewModel.TourViewModel TourVM { get; set; }
        public int Quantity { get; set; }
    }
}