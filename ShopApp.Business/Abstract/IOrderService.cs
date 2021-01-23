using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
   public interface IOrderService
    {
        Order GetById(int id);
        List<Order> GetByUserId(string id);
        void Create(Order entity);
        void Update(Order entity);
        void Delete(Order entity);
        List<Order> GetAll();
    }
}
