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
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterForAdmin model)
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
                    if (model.dateOfBirth != null)
                    {
                        user.ngaySinh = Convert.ToDateTime(model.dateOfBirth);
                    }
                    else
                    {
                        user.ngaySinh = null;
                    }
                    user.gioiTinh = model.gender;
                    user.status = model.status;
                    user.hinhAnh = model.avatar;
                    dao.Create(user);
                }
            }
            return View(model);
        }
    }
}