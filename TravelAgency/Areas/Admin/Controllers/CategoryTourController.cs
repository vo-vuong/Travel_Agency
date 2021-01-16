using Model.Dao;
using Model.EF;
using System.Web.Mvc;

namespace TravelAgency.Areas.Admin.Controllers
{
    public class CategoryTourController : BaseController
    {
        // GET: Admin/CategoryTour
        public ActionResult Index()
        {
            var dao = new CategoryTourDao();

            return View();
        }

        // GET: Admin/CategoryTour/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Post: Admin/CategoryTour/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(CATEGORY_TOUR model)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryTourDao();
                if (dao.CheckExist(model.CategoryName))
                {
                    ModelState.AddModelError("", "Tên danh mục tour đã tồn tại");
                }
                else
                {
                    dao.Create(model);
                    SetAlert("Thêm mới Tour thành công", "success");
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}