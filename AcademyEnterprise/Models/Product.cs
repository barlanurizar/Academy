using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AcademyEnterprise.Models.Enrollment;

namespace AcademyEnterprise.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
