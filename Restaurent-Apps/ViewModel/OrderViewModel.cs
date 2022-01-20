using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurent_Apps.ViewModel
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int PaymentTypeId { get; set; }
        public int CustomerId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Final_Total { get; set; }
    }
}