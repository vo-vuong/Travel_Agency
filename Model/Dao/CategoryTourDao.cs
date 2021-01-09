using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CategoryTourDao
    {
        private TravelAgencyDbContext db = null;
        
        public CategoryTourDao()
        {
            db = new TravelAgencyDbContext();
        }

        public List<CATEGORY_TOUR> ListAll()
        {
            return db.CATEGORY_TOUR.ToList();
        }

    }
}
