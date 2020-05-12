using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Agency.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Trường này là bắt buộc")]
        public string userName { set; get; }

        [Required(ErrorMessage = "Trường này là bắt buộc")]
        public string password { set; get; }

    //    public string CaptchaCode { get; set; }
    }
}