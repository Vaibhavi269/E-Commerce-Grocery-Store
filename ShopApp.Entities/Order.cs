using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodStatus { get; set; }
        public Cart Cart { get; set; }
        public int CartId { get; set; }
        public string UserId { get; set; }
        public double Amount { get; set; }
        public string PaymentType { get; set; }
        public Delivery DeliveryStatus { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public enum OrderStatus
    {
        Created,
        Updated,
        Canceled
    }
    public enum Delivery
    {
        Delivered,
        OnTheWay,
        Canceled
    }
}
