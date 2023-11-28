using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle: BaseDomainModel
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        // In SQL: constraint fk_ColourId foreign key (ColourId) references Colour (ColourId)
        // virtual allows "lazy loading" to create a proxy object to hold the FK reference.
        public int ColourId { get; set; }
        public virtual Colour? Colour { get; set; }
        // constraint fk_MakeId foreign key (MakeId) references Make (MakeId)
        public int MakeId { get; set; }
        public virtual Make? Make { get; set; }
        // constraint fk_ModelId foreign key (ModelId) references Model (ModelId)
        public int ModelId { get; set; }
        public virtual Model? Model { get; set; }
        // This is a "reverse reference" to Bookings. Because the foreign key in the Bookings-Vehicle
        // relationship is in the Bookings (many) side, there may be many Bookings for 1 Vehicle
        // instance. Each Booking is only for 1 Vehicle.
        // A Vehicle can have how many Bookings? Many. Cardinality is hence *.
        // Do all Vehicles need to have such? No. Participation is hence 0.
        // That is why, for the relationship's reverse side, multiplicity is 0..*
        public virtual List<Booking>? Bookings { get; set; }
    }
}
