using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelAgency.Areas.Admin.Models
{
    public class LoginModel
    {
        [Key]
        public int ID { get; set; }
        
        [Required(ErrorMessage ="Bạn phải nhập userName")]
        public string userName { get; set; }

        [Required(ErrorMessage ="Bạn phải nhập password")]
        public string password { get; set; }

        public bool Remember { get; set; }
    }
}