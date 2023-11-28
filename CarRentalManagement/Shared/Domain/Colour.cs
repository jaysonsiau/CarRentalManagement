using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    // Considering that this class does not have a foreign key and only has 1 uncommon attribute,
    // the creation of this class along with 2 others (make and model) is prioritised over the others.
    public class Colour: BaseDomainModel // Inherits from the base abstract class.
    {
        public string? Name { get; set; }
    }
}
