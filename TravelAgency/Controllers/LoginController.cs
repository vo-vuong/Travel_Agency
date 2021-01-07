using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
using TravelAgency.Models;
using TravelAgency.Common;
using BotDetect.Web.Mvc;
using System.Web.Security;

namespace TravelAgency.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [CaptchaValidationActionFilter("CaptchaCode", "LoginCaptcha", "Mã xác thực không chính xác!")]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new LoginDao();
                var result = dao.Login(model.userName, Encryptor.MD5Hash(model.password), false);
                if (result == 0)
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không chính xác");
                    MvcCaptcha.ResetCaptcha("LoginCaptcha");
                    return View("Index");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản của bạn đang bị khóa");
                    MvcCaptcha.ResetCaptcha("LoginCaptcha");
                    return View("Index");
                }
                else if (result == 1)
                {
                    var user = new UserDao().GetByUserName(model.userName);
                    var userSession = new UserLogin();
                    userSession.userName = user.UserName;
                    userSession.ID = user.IDAccount;
                    userSession.Image = user.Image;

                    Session.Add(Common.CommonConstant.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    MvcCaptcha.ResetCaptcha("LoginCaptcha");
                }
            }

            return View("Index");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("Index", controllerName: "Home");
        }
    }
}