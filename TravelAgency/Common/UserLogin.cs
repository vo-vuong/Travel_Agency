using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgency.Common
{
    [Serializable]
    public class UserLogin
    {
        public int ID { get; set; }

        public string userName { get; set; }

        public string Image { get; set; }
    }
}