using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;

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

        public IEnumerable<TOURSALE> ListTourSalePadding(int pageNumber, int pageSize)
        {
            return db.TOURSALEs.Where(x => x.Status == true).OrderByDescending(x => x.TOUR.DateCreated).ToPagedList(pageNumber, pageSize);
        }

        public IEnumerable<TOURSALE> ListTSalePriceASCPadding(int pageNumber, int pageSize)
        {
            return db.TOURSALEs.Where(x => x.Status == true).OrderBy(x => x.SaleRate).ToPagedList(pageNumber, pageSize);
        }

        public IEnumerable<TOURSALE> ListTSalePriceDESCPadding(int pageNumber, int pageSize)
        {
            return db.TOURSALEs.Where(x => x.Status == true).OrderByDescending(x => x.SaleRate).ToPagedList(pageNumber, pageSize);
        }
    }
}
