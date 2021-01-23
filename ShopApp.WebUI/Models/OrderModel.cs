using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Address BillingAddress { get; set; }
        public int BillingAddressId { get; set; }
        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodStatus { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public string PaymentType { get; set; }
        public Delivery DeliveryStatus { get; set; }
        public CartModel Cart { get; set; }
    }

}
