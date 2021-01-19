using Model.Dao;
using Model.EF;
using System.Web.Mvc;
using TravelAgency.Models;
using TravelAgency.Infrastructure.Extensions;

namespace TravelAgency.Areas.Admin.Controllers
{
    public class TourController : BaseController
    {
        // Author: VoXuanQuocVuong
        // Email:  vovuong1025@gmail.com
        // Date Modified: 20/1/2021
        private void SetViewBag()
        {
            var dao = new CategoryTourDao().ListAll();
            ViewBag.IDCategory = new SelectList(dao, "IDCategory", "CategoryName");
        }

        // GET: Admin/Tour
        [HttpGet]
        public ActionResult Index(string searchString, int pageNumber = 1, int pageSize = 10)
        {
            var model = new TourDao().ListPading(searchString, pageNumber, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        // GET: Admin/Tour/Create
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }

        // POST: Admin/Tour/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(TourViewModel model)
        {
            if (ModelState.IsValid)
            {
                TOUR tour = new TOUR();
                tour.UpdateTour(model);
                var dao = new TourDao().Create(tour);

                SetAlert("Thêm mới Tour thành công", "success");
                return RedirectToAction("Index");
            }
            SetViewBag();
            return View();
        }

        // GET: Admin/Tour/Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            SetViewBag();
            var model = new TourDao().ViewDetail(id);
            return View(model);
        }

        // POST: Admin/Tour/Edit
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(TourViewModel model)
        {
            //SetViewBag();
            TourDao dao = new TourDao();
            if (ModelState.IsValid)
            {
                TOUR tour = new TOUR();
                tour.UpdateTour(model);
                bool result = dao.Edit(tour);
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

        // POST: Ajax
        [HttpPost]
        public JsonResult Delete(int id)
        {
            var dao = new TourDao();
            bool flag = dao.Delete(id);
            return Json(new
            {
                status = flag
            });
        }

        // GET: Admin/Tour/Detail/id
        [HttpGet]
        public ActionResult Detail(int id)
        {
            var model = new TourDao().ViewDetail(id);
            return View(model);
        }
    }
}