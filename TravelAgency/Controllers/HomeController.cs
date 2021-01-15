using Model.Dao;
using System.Web.Mvc;

namespace TravelAgency.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ListTourAbroad = new TourDao().ListTourAbroad(8);
            ViewBag.ListTourDomestic = new TourDao().ListTourDomestic(8);
            ViewBag.ListTourHot = new TourDao().ListTourHot(4);
            ViewBag.ListTourSale = new TourSaleDao().ListTourSale(4);
            ViewBag.ListContentNew = new ContentDao().ListContentNew(3);
            return View();
        }

        public ActionResult MainMenu()
        {
            var dao = new MenuDao();
            var listMenu = dao.ListAll();
            return PartialView(listMenu);
        }
    }
}