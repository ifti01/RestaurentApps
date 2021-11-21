using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace Restaurent_Apps.Repositories
{
    public class PaymentRepository
    {
        private RestaurantDBEntities objRestaurantDbEntities ;
        public PaymentRepository()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllPayment()
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