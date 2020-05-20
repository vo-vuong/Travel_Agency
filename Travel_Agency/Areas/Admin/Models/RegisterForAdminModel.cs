using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Agency.Areas.Admin.Models
{
    public class RegisterForAdminModel
    {
        public string ID { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Yêu cầu nhập tên đăng nhập")]
        public string userName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage ="Yêu cần nhập mật khẩu")]
        [StringLength(maximumLength:20,ErrorMessage ="Độ dài mật khẩu từ 6-20 kí tự",MinimumLength =6)]
        public string password { get; set; }

        [DisplayName("Xác nhận mật khẩu")]
        [Compare("password",ErrorMessage ="Xác nhận mật khẩu không đúng")]
        public string confirmPassword { get; set; }


        [DisplayName("Loại tài khoản")]
        public int idUserGroup{ get; set; }


        [DisplayName("Email")]
        [Required(ErrorMessage = "Yêu cầu nhập Email")]
        public string email { get; set; }

        [DisplayName("Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập Họ tên")]
        public string name { get; set; }

        [DisplayName("Địa chỉ")]
        public string address { get; set; }

        [DisplayName("số điện thoại")]
        public string phone { get; set; }

        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Yêu cầu nhập ngày sinh")]
        public string dateOfBirth { get; set; }

        [DisplayName("Giới tính")]
        public bool gender { get; set; }

        [DisplayName("Trạng thái")]
        [Required(ErrorMessage = "Yêu cầu chọn trạng thái tài khoản")]
        public bool status { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string avatar { get; set; }
    }
}