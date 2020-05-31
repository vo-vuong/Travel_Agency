using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Model.Dao;
using Model.EF;

namespace TravelAgency.Areas.Admin.Controllers
{
    public class ContentController : BaseController
    {
        public void SetContentCategory()
        {
            var dao = new CategoryContentDao();
            ViewBag.IDContentCategory = new SelectList(dao.ListAll(), "IDContentCategory", "ContentCategoryName");
        }

        // GET: Admin/Content
        public ActionResult Index(string searchContentName, int pageStart = 1, int pageSize = 2)
        {
            var model = new ContentDao().ListAllPading(searchContentName, pageStart, pageSize);
            ViewBag.SearchContentName = searchContentName;
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            SetContentCategory();
            return View();
        }

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

        [HttpGet]
        [ValidateInput(false)]
        public ActionResult Edit(int id)
        {
            SetContentCategory();

            var model = new ContentDao().ViewDetail(id);
            return View(model);
        }

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
            return View(model);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var dao = new ContentDao();
            var result = dao.Delete(id);

            if (result)
            {
                SetAlert("Xóa bài viết thành công", "success");
                return RedirectToAction("Index");
            }
            else
            {
                SetAlert("Xóa bài viết không thành công", "warning");
                ModelState.AddModelError("", "Xóa bài viết không thành công");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            var model = new ContentDao().ViewDetail(id);
            return View(model);
        }

    }
}