using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class UserGroupDao
    {
        private TravelAgencyDbContext db = null;
        public UserGroupDao()
        {
            db = new TravelAgencyDbContext();
        }

        public List<USERGROUP> ListAll()
        {
            return db.USERGROUPs.ToList();
        }
    }
}
