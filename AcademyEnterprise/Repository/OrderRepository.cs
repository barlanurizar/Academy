using AcademyEnterprise.Data;
using AcademyEnterprise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AcademyEnterprise.Repository
{
    public class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository(AcademyEnterpriseContext context) : base(context)
        {
        }

       
        public override Order Update(Order Entity)
        {
            var order = context.Orders
                
                .Single(o => o.OrderID == Entity.OrderID);

            order.OrderName = Entity.OrderName;
            order.OrderCode = Entity.OrderCode;
            order.Description = Entity.Description;
            order.Price = Entity.Price;
            order.ImageUrl = Entity.ImageUrl;

            
            
            return base.Update(Entity);
        }
    }
    
}
