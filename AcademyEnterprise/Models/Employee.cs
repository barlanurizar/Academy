using System.Collections.Generic;

namespace AcademyEnterprise.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public string Description { get; set; }
        public double Salary { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
       

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
