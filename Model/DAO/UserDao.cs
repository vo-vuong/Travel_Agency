using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using PagedList;
using PagedList.Mvc;

namespace Model.DAO
{
    public class UserDao
    {
        Travel_AgencyDbContext db = null;

        public UserDao()
        {
            db = new Travel_AgencyDbContext();
        }

        public bool CheckMail(string email)
        {
            return db.TAIKHOANs.Count(x => x.email == email) > 0;
        }

        public bool CheckUserName(string userName)
        {
            return db.TAIKHOANs.Count(x => x.tenTaiKhoan == userName) > 0;
        }

        public TAIKHOAN ViewDetail(int id)
        {
            return db.TAIKHOANs.Find(id);
        }

        public TAIKHOAN GetByUserName(string userName)
        {
            return db.TAIKHOANs.SingleOrDefault(x => x.tenTaiKhoan == userName);
        }

        public IQueryable<TAIKHOAN> SearchString(string searchString)
        {
            return db.TAIKHOANs.Where(x => x.tenTaiKhoan.Contains(searchString));
        }

        public IEnumerable<TAIKHOAN> ListAllPaging(string searchString, int pageStart, int pageSize)
        {
            IQueryable<TAIKHOAN> model = db.TAIKHOANs;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = SearchString(searchString);
            }
            return model.OrderByDescending(x => x.ngayTao).ToPagedList(pageStart, pageSize);
        }

        public int Create(TAIKHOAN entity)
        {
            db.TAIKHOANs.Add(entity);
            db.SaveChanges();
            return entity.ma_TaiKhoan;
        }

        public bool Edit(TAIKHOAN entity)
        {
            try
            {
                var user = db.TAIKHOANs.Find(entity.ma_TaiKhoan);
                user.tenTaiKhoan = entity.tenTaiKhoan;
                user.ma_Nhom = entity.ma_Nhom;
                user.email = entity.email;
                user.matKhau = entity.matKhau;
                user.hoTen = entity.hoTen;
                user.diaChi = entity.diaChi;
                user.diaChi = entity.dienThoai;
                user.ngaySinh = entity.ngaySinh;
                user.gioiTinh = entity.gioiTinh;
                user.ngaySua = DateTime.Now;
                user.status = entity.status;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = db.TAIKHOANs.Find(id);
                db.TAIKHOANs.Remove(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Login(string userName, string password, bool isLoginAdmin = false)
        {
            var result = db.TAIKHOANs.SingleOrDefault(x => x.tenTaiKhoan == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (isLoginAdmin == true)
                {
                    if (result.ma_Nhom == Common.CommonGroupUser.Admin)
                    {
                        if (result.matKhau == password)
                        {
                            if (result.status == true)
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
                        if (result.status == true)
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
