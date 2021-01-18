using Model.EF;
using PagedList;
using System.Collections.Generic;
using System.Linq;

namespace Model.Dao
{
    /// <summary>
    /// The main <c>CategoryContentDao</c> class.
    /// Contains all methods for performing Category Content query functions
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// </summary>
    public class CategoryContentDao
    {
        private TravelAgencyDbContext db = null;

        public CategoryContentDao()
        {
            db = new TravelAgencyDbContext();
        }

        /// <summary>
        /// Query all fields of table CategoryContent and return the List<CONTENTCATEGORY> result
        /// </summary>
        /// <returns>A List<CONTENTCATEGORY></returns>
        public List<CONTENTCATEGORY> ListAll()
        {
            return db.CONTENTCATEGORies.ToList();
        }

        /// <summary>
        /// Check Exist category content name and return true if already exist of false
        /// </summary>
        /// <param name="categoryContentName">A tring category Content Name</param>
        /// <returns>A bool true if already exist or false</returns>
        public bool CheckExist(string categoryContentName)
        {
            return db.CONTENTCATEGORies.Count(x => x.ContentCategoryName == categoryContentName) > 0;
        }

        /// <summary>
        /// Query fields in table CONTENTCATEGORies with ContentCategoryName equal to param searchString
        /// </summary>
        /// <param name="searchString">A string to search</param>
        /// <returns>A IQueryable<CONTENTCATEGORY></returns>
        public IQueryable<CONTENTCATEGORY> SearchString(string searchString)
        {
            return db.CONTENTCATEGORies.Where(x => x.ContentCategoryName.Contains(searchString));
        }

        /// <summary>
        /// Query a listPading <CONTENTCATEGORY> with a param is pageStart and a param is pageSize.
        /// if the param searchString is other null, it is query ContentCategoryName equal searchString.
        /// </summary>
        /// <param name="searchString">A string searchString keyword</param>
        /// <param name="pageNumber">A int page Start</param>
        /// <param name="pageSize">A int Size pageList</param>
        /// <returns>A IEnumerable<CONTENTCATEGORY> with ASC</returns>
        public IEnumerable<CONTENTCATEGORY> ListPading(string searchString, int pageNumber, int pageSize)
        {
            IQueryable<CONTENTCATEGORY> model = db.CONTENTCATEGORies;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = SearchString(searchString);
            }
            return model.OrderBy(x => x.ContentCategoryName).ToPagedList(pageNumber, pageSize);
        }

        /// <summary>
        /// add entity of CONTENTCATEGORY to database and return this id
        /// </summary>
        /// <param name="entity">A entity of CONTENTCATEGORY</param>
        /// <returns>The IDCategory of this CONTENTCATEGORY</returns>
        public int Create(CONTENTCATEGORY entity)
        {
            db.CONTENTCATEGORies.Add(entity);
            db.SaveChanges();
            return entity.IDContentCategory;
        }

        /// <summary>
        /// Delete a entity of CONTENTCATEGORies in database and return bool
        /// </summary>
        /// <param name="ID">A id of enity ContentCategory</param>
        /// <returns>if true is successful or false is fail</returns>
        public bool Delete(int ID)
        {
            try
            {
                var entity = db.CONTENTCATEGORies.Find(ID);
                db.CONTENTCATEGORies.Remove(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}