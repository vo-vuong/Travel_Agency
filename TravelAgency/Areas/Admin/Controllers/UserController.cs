using Model.Dao;
using Model.EF;
using System;
using System.Web.Mvc;
using TravelAgency.Areas.Admin.Models;
using TravelAgency.Common;

namespace TravelAgency.Areas.Admin.Controllers
{
    // Author: VoXuanQuocVuong
    // Email:  vovuong1025@gmail.com
    // Date Modified: 19/01/2021
    public class UserController : BaseController
    {
        // Set viewBag for dropdown list role user
        private void SetViewBag()
        {
            var dao = new UserGroupDao();
            ViewBag.idUserGroup = new SelectList(dao.ListAll(), "IDUserGroup", "GroupName");
        }

        // GET: Admin/user
        [HttpGet]
        public ActionResult Index(string searchString, int pageStart = 1, int pageSize = 10)
        {
            var model = new UserDao().ListAllPaging(searchString, pageStart, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        // GET: Admin/user/Register
        [HttpGet]
        public ActionResult Register()
        {
            SetViewBag();
            return View();
        }

        // POST: Admin/user/Register
        [HttpPost]
        public ActionResult Register(RegisterAdminModel model)
        {
            SetViewBag();
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.CheckUserName(model.userName))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.CheckMail(model.email))
                {
                    ModelState.AddModelError("", "Email đã tồn tại");
                }
                else
                {
                    var user = new ACCOUNT();
                    user.UserName = model.userName;
                    user.IDUserGroup = model.idUserGroup;
                    user.Email = model.email;
                    user.Password = Encryptor.MD5Hash(model.password);
                    user.Name = model.name;
                    user.Address = model.address;
                    user.PhoneNumber = model.phone;
                    user.BirthDay = Convert.ToDateTime(model.dateOfBirth);
                    user.Grener = model.gender;
                    user.Status = model.status;
                    user.Image = model.avatar;
                    dao.Create(user);
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Admin/user/Edit/id
        [HttpGet]
        public ActionResult Edit(int id)
        {
            SetViewBag();
            var model = new UserDao().ViewDetail(id);
            return View(model);
        }

        // GET: Admin/user/Edit/
        [HttpPost]
        public ActionResult Edit(ACCOUNT model)
        {
            var dao = new UserDao();
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.Password))
                {
                    var passMD5 = Encryptor.MD5Hash(model.Password);
                    model.Password = passMD5;
                }

                bool result = dao.Edit(model);
                if (result)
                {
                    SetAlert("Sửa thành công", "success");
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    SetAlert("Cập nhật không thành công", "error");
                    ModelState.AddModelError("", "Cập nhật không thành công");
                }
            }
            return View("Index");
        }

        // Post: Ajax in file UserController.js
        [HttpPost]
        public JsonResult Delete(int id)
        {
            var dao = new UserDao();
            bool flag = dao.Delete(id);
            return Json(new
            {
                status = flag
            });
        }

        // GET: Admin/user/Detail/id
        [HttpGet]
        public ActionResult Detail(int id)
        {
            var model = new UserDao().ViewDetail(id);
            return View(model);
        }
    }
}