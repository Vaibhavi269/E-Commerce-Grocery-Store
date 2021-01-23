using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete
{
    public class EfCoreAddressDal : EfCoreGenericRepository<Address, ShopContext>, IAddressDal
    {
        
        public Address GetByUserId(string userId)
        {
            using (var context = new ShopContext())
            {
                return context
                            .Address
                            .FirstOrDefault(i => i.UserId == userId);
            }
        }


    }
}
