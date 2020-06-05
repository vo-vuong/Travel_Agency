using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class TourSaleDao
    {
        private TravelAgencyDbContext db = null;
        public TourSaleDao()
        {
            db = new TravelAgencyDbContext();
        }

        public List<TOURSALE> ListTourSale(int top)
        {
            return db.TOURSALEs.Where(x => x.Status == true).OrderByDescending(x => x.TOUR.DateCreated).Take(4).ToList();
        }
    }
}
