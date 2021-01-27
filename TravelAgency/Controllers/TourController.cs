using Model.Dao;
using System;
using System.Web.Mvc;

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
            ViewBag.ListTourHot = dao.ListTourHot(5);
            var model = dao.ViewDetailOrSale(id);
            return View(model);
        }

        public ActionResult Abroad(string sort, int pageNumber = 1, int pageSize = 6)
        {
            ViewBag.sort = sort;
            var dao = new TourDao();
            var model = dao.ListTourAbroadPadding(pageNumber, pageSize);

            if (sort == "tang-dan")
            {
                model = dao.ListTourAbroadPriceASCPadding(pageNumber, pageSize);
            }
            else if (sort == "giam-dan")
            {
                model = dao.ListTourAbroadPriceDESCPadding(pageNumber, pageSize);
            }
            return View(model);
        }

        public ActionResult Domestic(string sort, int pageNumber = 1, int pageSize = 6)
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

        public ActionResult Sale(string sort, int pageNumber = 1, int pageSize = 6)
        {
            ViewBag.sort = sort;
            var dao = new TourSaleDao();
            var model = dao.ListTourSalePadding(pageNumber, pageSize);

            if (sort == "tang-dan")
            {
                model = dao.ListTSalePriceASCPadding(pageNumber, pageSize);
            }
            else if (sort == "giam-dan")
            {
                model = dao.ListTSalePriceDESCPadding(pageNumber, pageSize);
            }
            return View(model);
        }

        public JsonResult ListName(string q)
        {
            var data = new TourDao().ListName(q);
            return Json(new
            {
                data = data,
                status = true
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search(string keyword, int page = 1, int pageSize = 10)
        {
            int totalRecord = 0;
            var model = new TourDao().Search(keyword, ref totalRecord, page, pageSize);

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;
            ViewBag.Keyword = keyword;
            int maxPage = 5;
            int totalPage = 0;

            totalPage = (int)Math.Ceiling((double)(totalRecord / pageSize));
            ViewBag.TotalPage = totalPage;
            ViewBag.MaxPage = maxPage;
            ViewBag.First = 1;
            ViewBag.Last = totalPage;
            ViewBag.Next = page + 1;
            ViewBag.Prev = page - 1;

            return View(model);
        }
    }
}