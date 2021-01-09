using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class MenuDao
    {
        private TravelAgencyDbContext db = null;

        public MenuDao()
        {
            db = new TravelAgencyDbContext();
        }

        public List<MENU> ListAll()
        {
            return db.MENUs.Where(x => x.Status == true).ToList();
        }
    }
}
