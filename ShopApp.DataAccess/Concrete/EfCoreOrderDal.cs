using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete
{
    public class EfCoreOrderDal : EfCoreGenericRepository<Order, ShopContext>, IOrderDal
    {

        public List<Order> GetByUserId(string userId)
        {         
            using (var context = new ShopContext())
            {
                return context
                            .Orders
                            .Include(i=>i.BillingAddress)
                            .Include(i => i.ShippingAddress)
                            .Include(i => i.OrderItems)
                            .ThenInclude(i=>i.Product)
                            .Where(i => i.UserId == userId).ToList();
            }
        }

        public List<Order> GetAll()
        {
            using (var context = new ShopContext())
            {
                return context
                            .Orders
                            .Include(i => i.BillingAddress)
                            .Include(i => i.ShippingAddress)
                            .Include(i => i.OrderItems)
                            .ThenInclude(i => i.Product).ToList();
            }
        }
    }
}
