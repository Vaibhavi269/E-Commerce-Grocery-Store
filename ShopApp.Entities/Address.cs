using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
   public class Address
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public AddressType AddressType { get; set; }
        public string UserId { get; set; }
    }

    public enum AddressType
    {
        ShippingAddress,
        BillingAddress
    }
}
