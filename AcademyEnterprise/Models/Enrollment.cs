using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyEnterprise.Models
{
    public class Enrollment
    {
       

        public int EnrollmentID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int EmployeetID { get; set; }
       

        public Order Order { get; set; }
        public Product Product { get; set; }
        public Employee Employee { get; set; }

      
    }
}
