using System;
using System.Collections.Generic;

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
    }
}
