using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.EmailServices;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private ICartService _cartService;
        private IEmailSender _emailSender;
        private IOrderService _orderService;
        private IAddressService _addressService;
        private UserManager<ApplicationUser> _userManager;
        public CheckoutController(ICartService cartService,IOrderService orderService, IEmailSender emailSender,
            IAddressService addressService, UserManager<ApplicationUser> userManager)
        {
            _addressService = addressService;
            _userManager = userManager;
            _cartService = cartService;
            _emailSender = emailSender;
            _orderService = orderService;
        }
        // GET: CheckoutController
        public ActionResult Index()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            if (cart == null || cart.CartItems.Count==0)
            {
                return RedirectToAction("Index","Cart");
            }
            ViewBag.userId = cart.UserId;
            var adress = _addressService.GetByUserId(cart.UserId);
            var adrModel = adress.Select(i => new AddressModel()
            {
                Id = i.Id,
                UserId=i.UserId,
                Address1=i.Address1,
                AddressType=i.AddressType,
                City=i.City,
                State=i.State,
                Country=i.Country,
                Email=i.Email,
                FullName=i.FullName,
                Phone=i.Phone,
                PostalCode=i.PostalCode
            });
            return View(adrModel);
        }


        [HttpPost]
        public async Task<ActionResult> Create(OrderModel order)
        {
            try
            {
              //  var adress = _addressService.GetByUserId(order.UserId);
                var cart = _cartService.GetCartByUserId(order.UserId);
                order.Cart.CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.Product.Id,
                    Name = i.Product.Name,
                    Price = (decimal)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity
                }).ToList();

   

                bool paid = true;
                if (order.PaymentMethod.Contains("Cash on Delivery (Pay Later)"))
                {
                    paid = false;
                    order.PaymentType = "Pay Later";
                }
                else
                {
                    order.PaymentType = "Credit/Debit Card";
                }

                var odr = new Order() {
                    ShippingAddressId= order.ShippingAddressId,
                    BillingAddressId = order.BillingAddressId,
                    UserId = order.UserId,
                    OrderStatus = OrderStatus.Created,
                    CreatedOn = DateTime.Now,
                    DeliveryStatus = Delivery.OnTheWay,
                    CartId = cart.Id,
                    Amount = Convert.ToDouble(order.Cart.TotalPrice()),
                    PaymentMethod = order.PaymentMethod,
                    PaymentMethodStatus = paid ? "Paid" : "Unpaid",
                    PaymentType = order.PaymentType,
                };
                var orderItems = cart.CartItems.Select(i => new OrderItem()
                {
                    OrderId=odr.Id,
                    ProductId = i.Product.Id,
                    Quantity = i.Quantity
                }).ToList();
                odr.OrderItems = orderItems;
                _orderService.Create(odr);
                ViewBag.message = "Your order completed successfully. Order number is : " + odr.Id;
                foreach (var oItems in orderItems)
                  _cartService.DeleteFromCart(order.UserId, oItems.ProductId);

                var usr = await _userManager.FindByIdAsync(odr.UserId);
                string html = "your order created successfully &nbsp;<br/><br/>";
                html += "<strong>Order No</strong> : " + odr.Id + "<br/>";
                html += "<strong>Order Status </strong>: " + odr.OrderStatus + "<br/>";
                html += "<strong>Delivery Status </strong>: " + odr.DeliveryStatus + "<br/>";

                await _emailSender.SendEmailAsync(usr.Email, "Order Successful",html);
                return View("ConfirmOrder");
            }
            catch(Exception ex)
            {
                ViewBag.message = "Your order failed. Please try again!";
                return View("ConfirmOrder");
            }
        }


        public IActionResult Payment()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            if (cart == null || cart.CartItems.Count == 0)
            {
                return RedirectToAction("Index", "Cart");
            }
            var adress = _addressService.GetByUserId(cart.UserId);
            var order = new OrderModel();
            order.Cart = new CartModel(){
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel() {
                    CartItemId = i.Id,
                    ProductId = i.Product.Id,
                    Name = i.Product.Name,
                    Price = (decimal)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity
                }).ToList()
            };

            order.BillingAddress = adress.FirstOrDefault(i => i.AddressType == AddressType.BillingAddress);
            order.ShippingAddress = adress.FirstOrDefault(i => i.AddressType == AddressType.ShippingAddress);
            order.UserId = cart.UserId;
            return View(order);
        }
    }
}
