using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BotDetect.Web.Mvc;
using Model.DAO;
using Model.EF;
using Travel_Agency.Areas.Admin.Models;
using Travel_Agency.Common;

namespace Travel_Agency.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        [HttpGet]
        public ActionResult Index(string searchString, int pageStart = 1, int pageSize = 1)
        {
            var dao = new UserDao();
            var model = dao.ListAllPaging(searchString, pageStart,pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterForAdminModel model)
        {
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
                    var user = new TAIKHOAN();
                    user.tenTaiKhoan = model.userName;
                    user.ma_Nhom = Convert.ToInt32(model.idUserGroup);
                    user.email = model.email;
                    user.matKhau = Encryptor.MD5Hash(model.password);
                    user.hoTen = model.name;
                    user.diaChi = model.address;
                    user.dienThoai = model.phone;
                    user.ngaySinh = Convert.ToDateTime(model.dateOfBirth);
                    user.gioiTinh = model.gender;
                    user.status = model.status;
                    user.hinhAnh = model.avatar;
                    dao.Create(user);
                }
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var dao = new UserDao();
            var model = dao.ViewDetail(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(TAIKHOAN model)
        {
            var dao = new UserDao();
            if (ModelState.IsValid)
            {
                if(!string.IsNullOrEmpty(model.matKhau))
                {
                    var passMD5 = Encryptor.MD5Hash(model.matKhau);
                    model.matKhau = passMD5;
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
            var dao = new UserDao().Delete(id);
            return View("Index");
        }

        public ActionResult Detail(int id)
        {
            var model = new UserDao().ViewDetail(id);
            return View(model);
        }
    }
}