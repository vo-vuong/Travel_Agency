using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelAgency.Models
{
    public class SignupModel
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Họ và tên *")]
        [Required(ErrorMessage = "Bạn phải nhập họ và tên")]
        public string name { get; set; }

        [DisplayName("Tên đăng nhập *")]
        [Required(ErrorMessage = "Bạn phải nhập tên đăng nhập")]
        public string userName { get; set; }

        [DisplayName("Mật khẩu *")]
        [Required(ErrorMessage = "Bạn phải nhập mật khẩu")]
        [StringLength(20,ErrorMessage ="Mật khẩu từ 6 đến 20 kí tự",MinimumLength =6)]
        public string passWord { get; set; }

        [DisplayName("Xác nhận mật khẩu *")]
        [Compare("passWord",ErrorMessage ="Xác nhận mật khẩu không đúng")]
        public string confirmPassWord { get; set; }

        [DisplayName("Email *")]
        [Required(ErrorMessage = "Bạn phải nhập Email")]
        [EmailAddress]
        public string email { get; set; }

        [DisplayName("Số điện thoại *")]
        [Required(ErrorMessage = "Bạn phải nhập số điện thoại")]
        public string phoneNumber { get; set; }

        [DisplayName("Ngày sinh")]
        [Required(ErrorMessage = "Bạn phải nhập ngày sinh")]
        [DataType(DataType.Date)]
        public string birthDay { get; set; }

        [DisplayName("Giới tính")]
        public bool gender { get; set; }

    }
}