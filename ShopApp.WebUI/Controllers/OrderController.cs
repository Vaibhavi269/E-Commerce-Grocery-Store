using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.EmailServices;
using ShopApp.WebUI.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {


        private IOrderService _orderService;
        private UserManager<ApplicationUser> _userManager;
        private IEmailSender _emailSender;

        public OrderController( IOrderService orderService, UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _orderService = orderService;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            if (User.IsInRole("admin"))
            {
                var order = _orderService.GetAll();
                return View(order);
            }
            else
            {
                var order = _orderService.GetByUserId(_userManager.GetUserId(User));
                return View(order);
            }
        }



        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            if (User.IsInRole("admin"))
            {
                var order = _orderService.GetById(id);
                return View(order);
            }
            return RedirectToAction("Index");
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Order order)
        {
            try
            {
                if (User.IsInRole("admin"))
                {
                    var odr = _orderService.GetById(id);
                    odr.OrderStatus = order.OrderStatus;
                    odr.DeliveryStatus = order.DeliveryStatus;

                    if (order.DeliveryStatus==Delivery.Delivered)
                        odr.PaymentMethodStatus = "Paid";
                    
                    _orderService.Update(odr);
                    var usr = await _userManager.FindByIdAsync(odr.UserId);
                    string html = "your order updated&nbsp;<br/><br/>";
                    html += "<strong>Order No</strong> : "+ odr .Id+ "<br/>";
                    html += "<strong>Order Status </strong>: " + odr.OrderStatus + "<br/>";
                    html += "<strong>Delivery Status </strong>: " + odr.DeliveryStatus + "<br/>";

                    await _emailSender.SendEmailAsync(usr.Email, "Order Updated", html);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    
    }
}
