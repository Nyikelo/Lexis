using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexisDeedTrackerApp.Models
{

    public class PropertyAddressModel
    {
        public string ERFNumber { get; set; }
        public string StreetNo { get; set; }
        public string StreetName { get; set; }
        public string ComplexName { get; set; }
        public string SurburbName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
    }
}
