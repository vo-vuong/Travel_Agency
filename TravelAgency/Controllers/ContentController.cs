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
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Index(int pageStart = 1, int pageSize = 5)
        {
            var dao = new ContentDao();
            var model = dao.ListAll(pageStart, pageSize);
            ViewBag.ListContentHotWeek = dao.ListContentHotWeek(3);

            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var dao = new ContentDao();
            var model = dao.ViewDetailClient(id);
            ViewBag.ListContentHotWeek = dao.ListContentHotWeek(3);
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult ContentHot()
        {
            var dao = new ContentDao();
            var model = dao.ListContentHot(5);
            return PartialView(model);
        }
    }
}