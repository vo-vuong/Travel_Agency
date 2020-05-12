using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Model.DAO
{
    public class UserDao
    {
        Travel_AgencyDbContext db = null;

        public UserDao()
        {
            db = new Travel_AgencyDbContext();
        }

        public int Login(string userName, string password, bool isLoginAdmin = false)
        {
            var result = db.TAIKHOANs.SingleOrDefault(x => x.tenTaiKhoan == userName);
            if(result == null)
            {
                return 0;
            }
            else
            {
                if(isLoginAdmin == true)
                {
                    if(result.ma_Nhom == Common.CommonGroupUser.Admin)
                    {
                        if (result.matKhau == password)
                        {
                            if(result.status == true)
                            {
                                return 1;
                            }
                            else { return -1; }
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
                    if (result.matKhau == password)
                    {
                        if(result.status == true)
                        {
                            return 1;
                        }
                        else { return -1; }
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

    }
}
