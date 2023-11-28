using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    // An abstract class is the foundation of the other classes.
    public abstract class BaseDomainModel
    {
        public int Id { get; set; } // All columns must begin with a capital letter.
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
