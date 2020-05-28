using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonModel;

namespace Model.Dao
{
    public class LoginDao
    {
        private TravelAgencyDbContext db = null;

        public LoginDao()
        {
            db = new TravelAgencyDbContext();
        }

        public int Login(string userName, string password, bool isLoginAdmin = false)
        {
            var result = db.ACCOUNTs.SingleOrDefault(x => x.UserName == userName);
            if(result == null)
            {
                return 0;
            }

            if(isLoginAdmin == true)
            {
                if(result.USERGROUP.IDUserGroup == CommonUserGroup.Admin)
                {
                    if(result.Password == password)
                    {
                        if(result.Status == true)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if(result.Password == password)
                {
                    if(result.Status == true)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
