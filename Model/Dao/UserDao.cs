using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Dao
{
    /// <summary>
    ///The main <c>UserDao</c> class.
    ///Contains all methods for performing User query functions
    ///Author: VoXuanQuocVuong
    ///Email: vovuong1025@gmail.com
    ///Date Modified: 19/01/2021
    /// </summary>
    public class UserDao
    {
        private TravelAgencyDbContext db = null;

        public UserDao()
        {
            db = new TravelAgencyDbContext();
        }

        public bool CheckMail(string email)
        {
            return db.ACCOUNTs.Count(x => x.Email == email) > 0;
        }

        public bool CheckUserName(string userName)
        {
            return db.ACCOUNTs.Count(x => x.UserName == userName) > 0;
        }

        public IQueryable<ACCOUNT> SearchString(string searchString)
        {
            return db.ACCOUNTs.Where(x => x.UserName.Contains(searchString));
        }

        public ACCOUNT ViewDetail(int id)
        {
            return db.ACCOUNTs.Find(id);
        }

        public IEnumerable<ACCOUNT> ListAllPaging(string searchString, int pageStart, int pageSize)
        {
            IQueryable<ACCOUNT> model = db.ACCOUNTs;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = SearchString(searchString);
            }
            return model.OrderByDescending(x => x.DateCreated).ToPagedList(pageStart, pageSize);
        }

        public ACCOUNT GetByUserName(string userName)
        {
            return db.ACCOUNTs.SingleOrDefault(x => x.UserName == userName);
        }

        public int Create(ACCOUNT entity)
        {
            try
            {
                var result = db.ACCOUNTs.Add(entity);
                db.SaveChanges();
                return result.IDAccount;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// Delete a entity of ACCOUNTs in database and return bool
        /// </summary>
        /// <param name="ID">A id of enity ACCOUNTs</param>
        /// <returns>if true is successful or false is fail</returns>
        public bool Delete(int ID)
        {
            try
            {
                var entity = db.ACCOUNTs.Find(ID);
                db.ACCOUNTs.Remove(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(ACCOUNT entity)
        {
            try
            {
                var user = db.ACCOUNTs.Find(entity.IDAccount);
                user.UserName = entity.UserName;
                user.IDUserGroup = entity.IDUserGroup;
                user.Email = entity.Email;
                if (!string.IsNullOrEmpty(entity.Password))
                {
                    user.Password = entity.Password;
                }
                user.Password = entity.Password;
                user.Name = entity.Name;
                user.Address = entity.Address;
                user.PhoneNumber = entity.PhoneNumber;
                user.BirthDay = entity.BirthDay;
                user.Grener = entity.Grener;
                user.DateModified = DateTime.Now;
                user.Status = entity.Status;
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