using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer: BaseDomainModel
    {
        public string? DrivingLicense { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }
        // Another reverse reference. In the Customer-Bookings relationship, 1 Customer can create
        // many Bookings but does not need to do so. That is why each Customer has a Bookings list.
        // In short, a Customer needs to see their own Bookings.
        public List<Booking>? Bookings { get; set; }
    }
}
