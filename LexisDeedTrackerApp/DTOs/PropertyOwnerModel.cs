using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexisDeedTrackerApp.Models
{
    public class PropertyOwnerModel
    {
        public string IDNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CellNumber { get; set; }

        public PropertyAddressModel PropertyAddres { get; set; }
    }

}
