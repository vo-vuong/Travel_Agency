using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Models;
using Model.Dao;
using Model.EF;
using TravelAgency.Common;
using CommonModel;

namespace TravelAgency.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterModel model)
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
                    var user = new ACCOUNT();
                    user.UserName = model.userName;
                    user.Password = Encryptor.MD5Hash(model.passWord);
                    user.Name = model.name;
                    user.Email = model.email;
                    user.PhoneNumber = model.phoneNumber;
                    user.BirthDay = Convert.ToDateTime(model.birthDay);
                    user.Grener = model.gender;
                    user.Status = true;
                    user.DateCreated = DateTime.Now;
                    user.IDUserGroup = CommonUserGroup.Member;
                    int result = dao.Create(user);
                    if(result == 0)
                    {
                        ModelState.AddModelError("", "Đăng kí thất bại!");
                    }
                    else
                    {
                        //var entity = dao.GetByUserName(model.userName);
                        var userSession = new UserLogin();
                        userSession.ID = user.IDAccount;
                        userSession.userName = user.UserName;
                        userSession.Image = user.Image;

                        Session.Add(Common.CommonConstant.USER_SESSION, userSession);
                        return RedirectToAction("Index", controllerName: "Home");
                    }
                    
                }
            }
            return View(model);
        }
    }
}