using System;
using System.Collections.Generic;
using System.Security.Cryptography;

#nullable disable

namespace FlyingDutchmanAirlines.DatabaseLayer.Models
{
    public sealed class Customer
    {
        public Customer(string name)
        {
            Bookings = new HashSet<Booking>();
            Name = name;
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public static bool operator ==(Customer x, Customer y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(Customer x, Customer y) => !(x == y);

        public override bool Equals(object obj)
        {
            var item = obj as Customer;

            if (item == null)
            {
                return false;
            }

            return this.CustomerId.Equals(item.CustomerId) && this.Name.Equals(item.Name);
        }

        public override int GetHashCode()
        {
            int randomNumber = RandomNumberGenerator.GetInt32(int.MaxValue / 2);
            return (this.CustomerId + this.Name.Length + randomNumber).GetHashCode();
        }
    }
}
