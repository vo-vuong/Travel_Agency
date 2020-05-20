using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Travel_Agency.Areas.Admin.Models;
using BotDetect.Web.Mvc;
using Travel_Agency.Common;

namespace Travel_Agency.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
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
                var dao = new UserDao();
                var result = dao.Login(model.userName, Common.Encryptor.MD5Hash(model.password), true);
                if(result == 1)
                {
                    var user = dao.GetByUserName(model.userName);
                    var userSession = new UserLogin();
                    userSession.UserID = user.ma_TaiKhoan;
                    userSession.UserName = user.tenTaiKhoan;

                    Session.Add(CommonConstant.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if(result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản của bạn đã bị khóa");
                }
                else if(result == 0)
                {
                    ModelState.AddModelError("","Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
            return View("Index");
        }
    }
}