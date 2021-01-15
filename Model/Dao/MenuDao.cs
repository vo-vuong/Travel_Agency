using Model.EF;
using System.Collections.Generic;
using System.Linq;

namespace Model.Dao
{
    /// <summary>
    /// The main MenuDao Class,
    /// Contains all methods for render Menu
    /// </summary>
    public class MenuDao
    {
        private TravelAgencyDbContext db = null;

        public MenuDao()
        {
            db = new TravelAgencyDbContext();
        }

        /// <summary>
        /// Query all field table Menu with Status == true and return the List<Menu> result
        /// </summary>
        /// <returns>The list of table menu</returns>
        public List<MENU> ListAll()
        {
            return db.MENUs.Where(x => x.Status == true).ToList();
        }
    }
}