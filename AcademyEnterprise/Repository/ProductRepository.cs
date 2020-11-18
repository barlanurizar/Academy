using AcademyEnterprise.Data;
using AcademyEnterprise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AcademyEnterprise.Repository
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(AcademyEnterpriseContext context) : base(context)
        {

        }
        public override Product Update(Product Entity)
        {
            var product = context.Product

                .Single(p => p.ProductID == Entity.ProductID);

            product.ProductName = Entity.ProductName;
            product.ProductCode = Entity.ProductCode;
            product.Description = Entity.Description;
            product.Price = Entity.Price;
            product.ImageUrl = Entity.ImageUrl;


            return base.Update(product);
        }



    }
            
          
    
    
}
