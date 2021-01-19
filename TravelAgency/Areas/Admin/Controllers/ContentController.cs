using Model.Dao;
using Model.EF;
using System.Web.Mvc;

namespace TravelAgency.Areas.Admin.Controllers
{
    // Author: VoXuanQuocVuong
    // Email:  vovuong1025@gmail.com
    // Date Modified: 19/01/2021
    public class ContentController : BaseController
    {
        public void SetContentCategory()
        {
            var dao = new CategoryContentDao();
            ViewBag.IDContentCategory = new SelectList(dao.ListAll(), "IDContentCategory", "ContentCategoryName");
        }

        // GET: Admin/Content
        public ActionResult Index(string searchContentName, int pageStart = 1, int pageSize = 10)
        {
            var model = new ContentDao().ListAllPading(searchContentName, pageStart, pageSize);
            ViewBag.SearchContentName = searchContentName;
            return View(model);
        }

        // GET: Admin/Content/Create
        [HttpGet]
        public ActionResult Create()
        {
            SetContentCategory();
            return View();
        }

        // POST: Admin/Content/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(CONTENT model)
        {
            SetContentCategory();

            if (ModelState.IsValid)
            {
                var userSession = (Common.UserLogin)Session[Common.CommonConstant.USER_SESSION];
                model.IDAccount = userSession.ID;
                bool result = new ContentDao().Create(model);
                if (result)
                {
                    SetAlert("Thêm bài viết thành công", "success");
                    return RedirectToAction("Index");
                }
                else
                {
                    SetAlert("Thêm bài viết thất bại", "error");
                    ModelState.AddModelError("", "Thêm bài viết thất bại");
                }
            }
            return View();
        }

        // GET: Admin/Content/Edit/id
        [HttpGet]
        [ValidateInput(false)]
        public ActionResult Edit(int id)
        {
            SetContentCategory();

            var model = new ContentDao().ViewDetail(id);
            return View(model);
        }

        // POST: Admin/Content/id
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(CONTENT model)
        {
            SetContentCategory();

            var dao = new ContentDao();
            if (ModelState.IsValid)
            {
                var result = dao.Edit(model);
                if (result)
                {
                    SetAlert("Sửa bài viết thành công", "success");
                    return RedirectToAction("Index");
                }
                else
                {
                    SetAlert("Sửa bài viết không thành công", "warning");
                    ModelState.AddModelError("", "Sửa bài viết không thành công");
                }
            }
            return View("Index");
        }

        // POST: Ajax in contentController.js
        [HttpPost]
        public JsonResult Delete(int id)
        {
            var dao = new ContentDao();
            bool flag = dao.Delete(id);
            return Json(new
            {
                status = flag
            });
        }

        // GET: Admin/Content/Detail/id
        [HttpGet]
        public ActionResult Detail(int id)
        {
            var model = new ContentDao().ViewDetail(id);
            return View(model);
        }
    }
}