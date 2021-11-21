using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurent_Apps.Repositories
{
    public class CustomerRepository
    {
        private RestaurantDBEntities objRestaurantDbEntities;
        public CustomerRepository()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDbEntities.PaymentTypes
                select new SelectListItem()
                {
                    Text = obj.PaymentTypeName,
                    Value = obj.PaymentTypeId.ToString(),
                    Selected = true,

                }).ToList();

            return objSelectListItems;
        }
    }
}