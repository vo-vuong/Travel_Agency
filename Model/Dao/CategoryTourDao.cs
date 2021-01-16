using Model.EF;
using PagedList;
using System.Collections.Generic;
using System.Linq;

namespace Model.Dao
{
    /// <summary>
    /// The main <c>CategoryTourDao</c> class.
    /// Contains all methods for performing Category Tour query functions
    /// </summary>
    public class CategoryTourDao
    {
        private TravelAgencyDbContext db = null;

        public CategoryTourDao()
        {
            db = new TravelAgencyDbContext();
        }

        /// <summary>
        /// Query all field of table CategoryTour and return the List<CATEGORY_TOUR> result
        /// </summary>
        /// <returns>A List<CATEGORY_TOUR></returns>
        public List<CATEGORY_TOUR> ListAll()
        {
            return db.CATEGORY_TOUR.ToList();
        }

        /// <summary>
        /// Check Exist category tour name and return true if already exist of false
        /// </summary>
        /// <param name="categoryTourName">A tring Category Tour Name</param>
        /// <returns>A bool true if already exist or false</returns>
        public bool CheckExist(string categoryTourName)
        {
            return db.CATEGORY_TOUR.Count(x => x.CategoryName == categoryTourName) > 0;
        }

        /// <summary>
        /// Query fields in table CATEGORY_TOUR with CategoryName equal to param searchString
        /// </summary>
        /// <param name="searchString">A string to search</param>
        /// <returns>A IQueryable<CATEGORY_TOUR></returns>
        public IQueryable<CATEGORY_TOUR> SearchString(string searchString)
        {
            return db.CATEGORY_TOUR.Where(x => x.CategoryName.Contains(searchString));
        }

        /// <summary>
        /// Query a listPading <CATEGORY_TOUR> with a param is pageStart and a param is pageSize.
        /// if the param searchString is other null, it is query CategoryName equal searchString.
        /// </summary>
        /// <param name="searchString">A string searchString keyword</param>
        /// <param name="pageNumber">A int page Start</param>
        /// <param name="pageSize">A int Size pageList</param>
        /// <returns>A IEnumerable<CATEGORY_TOUR> with DESC</returns>
        public IEnumerable<CATEGORY_TOUR> ListPading(string searchString, int pageNumber, int pageSize)
        {
            IQueryable<CATEGORY_TOUR> model = db.CATEGORY_TOUR;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = SearchString(searchString);
            }
            return model.OrderByDescending(x => x.CategoryName).ToPagedList(pageNumber, pageSize);
        }

        /// <summary>
        /// add entity of CATEGORY_TOUR to database and return this id
        /// </summary>
        /// <param name="entity">A entity of CATEGORY_TOUR</param>
        /// <returns>The IDCategory of this CATEGORY_TOUR</returns>
        public int Create(CATEGORY_TOUR entity)
        {
            db.CATEGORY_TOUR.Add(entity);
            db.SaveChanges();
            return entity.IDCategory;
        }
    }
}