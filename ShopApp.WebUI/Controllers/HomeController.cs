using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private IAddressService _addressService;

        public HomeController(IProductService productService,IAddressService addressService)
        {
            _productService = productService;
            _addressService = addressService;
        }
        public IActionResult Index()
        {
            return View(new ProductListModel()
            {
                Products = _productService.GetAll()
            });
        }

        [HttpPost]
        public IActionResult AddAddress(AddressModel address)
        {
            if (!ModelState.IsValid)
            {
                return View("EditAddress", address);
            }
            var adr = new Address()
            {
                Id = address.Id,
                UserId = address.UserId,
                Address1 = address.Address1,
                AddressType = address.AddressType,
                City = address.City,
                State = address.State,
                Country = address.Country,
                Email = address.Email,
                FullName = address.FullName,
                Phone = address.Phone,
                PostalCode = address.PostalCode
            };

            if (adr.Id==0)
            {
                _addressService.Create(adr);
            }
            else
            {
                _addressService.Update(adr);
            }
           
            return RedirectToAction("Index","Checkout");
        }

        public IActionResult EditAddress(int id)
        {
            var i= _addressService.GetById(id);
            var adrModel = new AddressModel()
            {
                Id = i.Id,
                UserId = i.UserId,
                Address1 = i.Address1,
                AddressType = i.AddressType,
                City = i.City,
                State = i.State,
                Country = i.Country,
                Email = i.Email,
                FullName = i.FullName,
                Phone = i.Phone,
                PostalCode = i.PostalCode
            };
            return View(adrModel);
        }
    }
}
