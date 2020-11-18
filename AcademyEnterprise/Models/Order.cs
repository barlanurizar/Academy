using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyEnterprise.Models
{
    public class Order
    {
        public enum Grade
        {
            A, B, C, D, F
        }

        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public string OrderCode { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
      
    }
}
