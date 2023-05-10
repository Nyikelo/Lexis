using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexisDeedTrackerDataAccess.Core
{
    public class PropertyOwner
    {
        public int OwnerID { get; set; }
        public string IDNumber { get; set; }
        public  string  FirstName { get; set; }
        public string Surname { get; set; }
        public string CellNumber { get; set; }

        public PropertyAddress PropertyAddress { get; set; }
    }

}
