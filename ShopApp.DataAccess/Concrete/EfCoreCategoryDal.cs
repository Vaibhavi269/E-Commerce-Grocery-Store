using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete
{
    public class EfCoreCategoryDal : EfCoreGenericRepository<Category, ShopContext>, ICategoryDal
    {
        public void DeleteFromCategory(int productId, int categoryId)
        {
            using var context = new ShopContext();
            var cmd = @"delete from ProductCategory where ProductId=@p0 and CategoryId=@p1";
            context.Database.ExecuteSqlRaw(cmd, productId, categoryId);
        }

        public Category GetByIdWithProducts(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Categories.Where(i => i.Id == id)
                                         .Include(i => i.ProductCategories)
                                         .ThenInclude(i => i.Product).FirstOrDefault();
            }
        }
    }
}
