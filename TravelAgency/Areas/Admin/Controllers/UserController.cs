using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Agency.Common;
using TravelAgency.Areas.Admin.Models;

namespace TravelAgency.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private void SetViewBag()
        {
            var dao = new UserGroupDao();
            ViewBag.idUserGroup = new SelectList(dao.ListAll(), "IDUserGroup", "GroupName");
        }

        [HttpGet]
        public ActionResult Index(string searchString, int pageStart = 1, int pageSize = 10)
        {
            var model = new UserDao().ListAllPaging(searchString, pageStart, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        [HttpGet]
        public ActionResult Register()
        {
            SetViewBag();
            return View();
        }

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
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            SetViewBag();
            var model = new UserDao().ViewDetail(id);
            return View(model);
        }

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

        public ActionResult Delete(int id)
        {
            SetAlert("Xóa thành Công", "success");
            var dao = new UserDao().Delete(id);
            return RedirectToAction("Index", "User");
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            var model = new UserDao().ViewDetail(id);
            return View(model);
        }

    }
}