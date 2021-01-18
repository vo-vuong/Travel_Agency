using Model.Dao;
using Model.EF;
using System.Web.Mvc;

namespace TravelAgency.Areas.Admin.Controllers
{
    // Author: VoXuanQuocVuong
    // Email: vovuong1025@gmail.com
    public class CategoryContentController : BaseController
    {
        // GET: Admin/CategoryContent
        public ActionResult Index(string searchString, int pageNumber = 1, int pageSize = 5)
        {
            var dao = new CategoryContentDao();
            var model = dao.ListPading(searchString, pageNumber, pageSize);
            ViewBag.SeachString = searchString;
            return View(model);
        }

        // GET: Admin/CategoryContent/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Post: Admin/CategoryContent/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(CONTENTCATEGORY model)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryContentDao();
                if (dao.CheckExist(model.ContentCategoryName))
                {
                    ModelState.AddModelError("", "Tên danh mục tour đã tồn tại");
                }
                else
                {
                    dao.Create(model);
                    SetAlert("Thêm mới danh mục bài viết thành công", "success");
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        // Ajax HttPost
        [HttpPost]
        public JsonResult Delete(int id)
        {
            var dao = new CategoryContentDao();
            bool flag = dao.Delete(id);
            return Json(new
            {
                status = flag
            });
        }
    }
}