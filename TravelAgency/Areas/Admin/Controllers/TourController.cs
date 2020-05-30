using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace TravelAgency.Areas.Admin.Controllers
{
    public class TourController : BaseController
    {
        private void SetViewBag()
        {
            var dao = new CategoryTourDao().ListAll();
            ViewBag.IDCategory = new SelectList(dao, "IDCategory", "CategoryName");
        }

        // GET: Admin/Tour
        [HttpGet]
        public ActionResult Index(string searchString, int pageNumber = 1, int pageSize = 3)
        {
            var model = new TourDao().ListPading(searchString, pageNumber, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(TOUR model)
        {
            if (ModelState.IsValid)
            {
                var dao = new TourDao().Create(model);

                SetAlert("Thêm mới Tour thành công", "success");
                return RedirectToAction("Index");
            }
            SetViewBag();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            SetViewBag();
            var model = new TourDao().ViewDetail(id);
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(TOUR model)
        {
            TourDao dao = new TourDao();
            if (ModelState.IsValid)
            {
                bool result = dao.Edit(model);
                if (result)
                {
                    SetAlert("Sửa Tour thành công", "success");
                    return RedirectToAction("Index");
                }
                else
                {
                    SetAlert("Sửa Tour thất bại", "error");
                    ModelState.AddModelError("", "Cập nhật không thành công");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var dao = new TourDao();
            var result = dao.Delete(id);
            if (result)
            {
                SetAlert("Xóa Tour thành công", "success");
                return RedirectToAction("Index");
            }
            else
            {
                SetAlert("Xóa Tour thất bại", "error");
                return View("Index");
            }
        }

        public ActionResult Detail(int id)
        {
            var model = new TourDao().ViewDetail(id);
            return View(model);
        }

    }
}