using AcademyEnterprise.Data;
using AcademyEnterprise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyEnterprise.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(AcademyEnterpriseContext context) : base(context)
        {

        }
        public override Employee Update(Employee Entity)
        {
            var Employee = context.Employee

                .Single(p => p.EmployeeID == Entity.EmployeeID);

            Employee.EmployeeName = Entity.EmployeeName;

            Employee.EmployeeCode = Entity.EmployeeCode;
            Employee.Description = Entity.Description;
            Employee.Salary = Entity.Salary;
            Employee.ImageUrl = Entity.ImageUrl;
            Employee.Category = Entity.Category;


            return base.Update(Employee);
        }
    }
}
