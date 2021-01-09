using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class ContentDao
    {
        private TravelAgencyDbContext db = null;

        public ContentDao()
        {
            db = new TravelAgencyDbContext();
        }

        private IQueryable<CONTENT> SearchContentName(string contentName)
        {
            return db.CONTENTs.Where(x => x.ContentName.Contains(contentName));
        }

        public IEnumerable<CONTENT> ListAllPading(string contentName, int pageNumber, int pageSize)
        {
            IQueryable<CONTENT> model = db.CONTENTs;
            if (!string.IsNullOrEmpty(contentName))
            {
                model = SearchContentName(contentName);
            }
            return model.OrderByDescending(x => x.DateCreated).ToPagedList(pageNumber,pageSize);
        }

        public IEnumerable<CONTENT> ListAll(int pageNumber, int pageSize)
        {
            return db.CONTENTs.Where(x => x.status == true && x.dateShow <= DateTime.Now).OrderByDescending(x => x.dateShow).ToPagedList(pageNumber, pageSize);
        }

        public CONTENT ViewDetail(int id)
        {
            return db.CONTENTs.Find(id);
        }


        public bool Create(CONTENT entity)
        {
            try
            {
                db.CONTENTs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(CONTENT entity)
        {
            try
            {
                var content = db.CONTENTs.Find(entity.IDContent);
                content.ContentName = entity.ContentName;
                content.body = entity.body;
                content.shortBody = entity.shortBody;
                content.Image = entity.Image;
                content.DateModified = DateTime.Now;
                content.status = entity.status;
                content.IDContent = entity.IDContent;
                content.dateShow = entity.dateShow;
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var content = db.CONTENTs.Find(id);
                db.CONTENTs.Remove(content);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        //Section Client
        #region

        public List<CONTENT> ListContentNew(int top)
        {
            return db.CONTENTs.Where(x => x.status == true && x.dateShow <= DateTime.Now).OrderByDescending(x => x.dateShow).Take(top).ToList();
        }

        public CONTENT ViewDetailClient(int id)
        {
            var entity = db.CONTENTs.Find(id);
            entity.views += 1;
            db.SaveChanges();
            return entity;
        }

        public List<CONTENT> ListContentHot(int top)
        {
            return db.CONTENTs.Where(x => DbFunctions.DiffDays(x.dateShow, DateTime.Now) <= 30 && x.status == true && x.dateShow <= DateTime.Now).OrderByDescending(x =>x.views).Take(top).ToList();
        }

        public List<CONTENT> ListContentHotWeek(int top)
        {
            return db.CONTENTs.Where(x => DbFunctions.DiffDays(x.dateShow,DateTime.Now) <= 7 && x.status == true && x.dateShow <= DateTime.Now).OrderByDescending(x => x.views).Take(top).ToList();
        }

        #endregion






    }
}
