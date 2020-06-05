﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class TourDao
    {
        private TravelAgencyDbContext db = null;

        public TourDao()
        {
            db = new TravelAgencyDbContext();
        }

        public TOUR ViewDetail(int id)
        {
            return db.TOURs.Find(id);
        }

        public IQueryable<TOUR> SearchString(string searchString)
        {
            return db.TOURs.Where(x => x.TourName.Contains(searchString));
        }

        public IEnumerable<TOUR> ListPading(string searchString, int pageNumber, int pageSize)
        {
            IQueryable<TOUR> model = db.TOURs;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = SearchString(searchString);
            }
            return model.OrderByDescending(x => x.DateCreated).ToPagedList(pageNumber, pageSize);
        }

        public int Create(TOUR entity)
        {
            entity.DateCreated = DateTime.Today;
            entity.Views = 0;
            db.TOURs.Add(entity);
            db.SaveChanges();
            return entity.IDTour;
        }

        public bool Edit(TOUR entity)
        {
            try
            {
                var tour = db.TOURs.Find(entity.IDTour);
                tour.TourName = entity.TourName;
                tour.Description = entity.Description;
                tour.Image = entity.Image;
                tour.Price = entity.Price;
                tour.Quantity = entity.Quantity;
                tour.Status = entity.Status;
                tour.DateStart = entity.DateStart;
                tour.Time = entity.Time;
                tour.LocationStart = entity.LocationStart;
                tour.IDCategory = entity.IDCategory;
                tour.DateModified = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit2(TOUR entity)
        {
            try
            {
                var user = db.TOURs.Find(entity.IDTour);
                user.TourName = entity.TourName;
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
                var entity = db.TOURs.Find(id);
                db.TOURs.Remove(entity);
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

        public List<TOUR> ListNewTour(int top)
        {
            return db.TOURs.Where(x => x.Status == true).OrderByDescending(x => x.DateCreated).ToList();
        }

        public List<TOUR> ListTourAbroad(int top)
        {
            return db.TOURs.Where(x => x.IDCategory == 2 && x.Status == true).OrderByDescending(x => x.DateCreated).Take(top).ToList();
        }

        public List<TOUR> ListTourDomestic(int top)
        {
            return db.TOURs.Where(x => x.IDCategory == 1 && x.Status == true).OrderByDescending(x => x.DateCreated).Take(top).ToList();
        }

        public List<TOUR> ListTourHot(int top)
        {
            return db.TOURs.Where(x => x.Status == true).OrderBy(x => x.DateStart).Take(top).ToList();
        }

        #endregion

    }
}