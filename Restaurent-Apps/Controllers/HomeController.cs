using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using Restaurent_Apps.Repositories;

namespace Restaurent_Apps.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantDBEntities objRestaurantDbEntities;
        public HomeController()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();
        }
        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository();
            ItemRepository objItemRepository = new ItemRepository();
            PaymentRepository objPaymentRepository = new PaymentRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>,IEnumerable<SelectListItem>>
                (objCustomerRepository.GetAllCustomers(),objItemRepository.GetAllItems(),objPaymentRepository.GetAllPayment());


            return View(objMultipleModels);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal UnitPrice = objRestaurantDbEntities.Items.Single(model => model.ItemId == itemId).ItemPrice;
            return Json(UnitPrice,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}