using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
using PagedList;
using PagedList.Mvc;

namespace TravelAgency.Controllers
{
    public class TourController : Controller
    {
        // GET: Tour
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            var dao = new TourDao();
            var model = dao.ViewDetail(id);
            return View(model);
        }

        public ActionResult Abroad(string sort, int pageNumber = 1, int pageSize = 12)
        {
            ViewBag.sort = sort;
            var dao = new TourDao();
            var model = dao.ListTourAbroadPadding(pageNumber, pageSize);

            if (sort == "tang-dan")
            {
                model = dao.ListTourAbroadPriceASCPadding(pageNumber, pageSize);
            }else if(sort == "giam-dan")
            {
                model = dao.ListTourAbroadPriceDESCPadding(pageNumber, pageSize);
            }
            return View(model);
        }

        public ActionResult Domestic(string sort, int pageNumber = 1, int pageSize = 12)
        {
            ViewBag.sort = sort;
            var dao = new TourDao();
            var model = dao.ListTourDomesticPadding(pageNumber, pageSize);

            if (sort == "tang-dan")
            {
                model = dao.ListTourDomesticPriceASCPadding(pageNumber, pageSize);
            }
            else if (sort == "giam-dan")
            {
                model = dao.ListTourDomesticPriceDESCPadding(pageNumber, pageSize);
            }
            return View(model);
        }

        public ActionResult Sale(string sort, int pageNumber = 1, int pageSize = 12)
        {
            ViewBag.sort = sort;
            var dao = new TourSaleDao();
            var model = dao.ListTourSalePadding(pageNumber, pageSize);
            
            if(sort == "tang-dan")
            {
                model = dao.ListTSalePriceASCPadding(pageNumber, pageSize);
            }else if(sort == "giam-dan")
            {
                model = dao.ListTSalePriceDESCPadding(pageNumber, pageSize);
            }
            return View(model);
        }
    }
}