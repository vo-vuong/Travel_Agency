using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelAgency.Common;
using TravelAgency.Areas.Admin.Models;

namespace TravelAgency.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new LoginDao();

                var result = dao.Login(model.userName, Encryptor.MD5Hash(model.password), true);
                if (result == 1)
                {
                    var account = new UserDao().GetByUserName(model.userName);

                    var userSession = new UserLogin();
                    userSession.ID = account.IDAccount;
                    userSession.userName = account.UserName;
                    userSession.Image = account.Image;

                    Session.Add(CommonConstant.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không chính xác");
                }else if(result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản của bạn đang bị khóa");
                }
            }
            return View("Index");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return View("Index");
        }

    }
}