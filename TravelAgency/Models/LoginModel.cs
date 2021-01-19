using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>LoginViewModel</c> class.
    /// Contains all properties of Login entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Modified: 19/01/2021
    /// </summary>
    public class LoginModel
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Bạn phải nhập tên đăng nhập")]
        public string userName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Bạn phải nhập mật khẩu")]
        public string password { get; set; }

        public bool Remember { get; set; }
    }
}