using AcademyEnterprise.Models;
using System;
using System.Linq;

namespace AcademyEnterprise.Data
{
    public static class DbInitiliazer
    {
        public static void Initialize(AcademyEnterpriseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Products.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            var Products = new Product[]
            {
                new Product{ProductName="Carson",ProductCode="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Product{ProductName="Meredith",ProductCode="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Product{ProductName="Arturo",ProductCode="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Product{ProductName="Gytis",ProductCode="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Product{ProductName="Yan",ProductCode="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Product{ProductName="Peggy",ProductCode="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Product{ProductName="Laura",ProductCode="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Product{ProductName="Nino",ProductCode="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Product.AddRange(Products);
            context.SaveChanges();

            var Orders = new Order[]
            {
                new Order{OrderID=1050,OrderName="Chemistry",Quantity=3},
                new Order{OrderID=4022,OrderName="Microeconomics",Quantity=3},
                new Order{OrderID=4041,OrderName="Macroeconomics",Quantity=3},
                new Order{OrderID=1045,OrderName="Calculus",Quantity=4},
                new Order{OrderID=3141,OrderName="Trigonometry",Quantity=4},
                new Order{OrderID=2021,OrderName="Composition",Quantity=3},
                new Order{OrderID=2042,OrderName="Literature",Quantity=4}
            };

            context.Orders.AddRange(Orders);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{ProductID=1,OrderID=1050},
                new Enrollment{ProductID=1,OrderID=4022},
                new Enrollment{ProductID=1,OrderID=4041},
                new Enrollment{ProductID=2,OrderID=1045},
                new Enrollment{ProductID=2,OrderID=3141},
                new Enrollment{ProductID=2,OrderID=2021},
                new Enrollment{ProductID=3,OrderID=1050},
                new Enrollment{ProductID=4,OrderID=1050},
                new Enrollment{ProductID=4,OrderID=4022},
                new Enrollment{ProductID=5,OrderID=4041},
                new Enrollment{ProductID=6,OrderID=1045},
                new Enrollment{ProductID=7,OrderID=3141},
            };

            context.Enrollment.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
