using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
   public interface IAddressService
    {
        Address GetById(int id);
        IEnumerable<Address> GetByUserId(string id);
        void Create(Address entity);
        void Update(Address entity);
        void Delete(Address entity);
    }
}
