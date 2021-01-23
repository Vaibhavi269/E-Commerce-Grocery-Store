using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.Business.Concrete
{
    public class AddressManager : IAddressService
    {
        private IAddressDal _AddessDal;
        public AddressManager(IAddressDal cartDal)
        {
            _AddessDal = cartDal;
        }
        public void Create(Address entity)
        {
            _AddessDal.Create(entity);
        }

        public void Delete(Address entity)
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {
           return _AddessDal.GetById(id);
        }

        public IEnumerable<Address> GetByUserId(string id)
        {

            return _AddessDal.GetAll().Where(i => i.UserId == id);
        }

        public void Update(Address entity)
        {
            _AddessDal.Update(entity);
        }
    }
}
