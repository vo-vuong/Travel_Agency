using Model.Dao;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";

        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItemModel>();
            if (cart != null)
            {
                list = (List<CartItemModel>)cart;
            }
            return View(list);
        }

        public ActionResult AddItem(int idTour, int quantity)
        {
            var product = new TourDao().ViewDetailOrSale(idTour);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItemModel>)cart;
                if (list.Exists(x => x.TourVM.IDTour == idTour))
                {
                    foreach (var item in list)
                    {
                        if (item.TourVM.IDTour == idTour)
                        {
                            item.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    //Tạo mới đối tượng cart item
                    var item = new CartItemModel();
                    item.TourVM = product;
                    item.Quantity = quantity;
                    list.Add(item);
                }
                //Gán vào session
                Session[CartSession] = list;
            }
            else
            {
                //Tạo mới đối tượng cart item
                var item = new CartItemModel();
                item.TourVM = product;
                item.Quantity = quantity;
                var list = new List<CartItemModel>();
                list.Add(item);
                //Gán vào Session
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }

        public JsonResult Delete(int id)
        {
            var sessionCart = (List<CartItemModel>)Session[CartSession];
            sessionCart.RemoveAll(x => x.TourVM.IDTour == id);
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartItemModel>>(cartModel);
            var sessionCart = (List<CartItemModel>)Session[CartSession];

            foreach (var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.TourVM.IDTour == item.TourVM.IDTour);
                if (jsonItem != null)
                {
                    item.Quantity = jsonItem.Quantity;
                }
            }
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }
    }
}