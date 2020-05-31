using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class CategoryContentDao
    {
        private TravelAgencyDbContext db = null;

        public CategoryContentDao()
        {
            db = new TravelAgencyDbContext();
        }

        public List<CONTENTCATEGORY> ListAll()
        {
            return db.CONTENTCATEGORies.ToList();
        }
    }
}
