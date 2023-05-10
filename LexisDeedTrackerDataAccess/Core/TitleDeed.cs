using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexisDeedTrackerDataAccess.Core
{
    public class TitleDeed
    {
        public int TitleDeedId { get; set; }
        public string Notes { get; set; }
        public DateTime DateLodged { get; set; }
        public DateTime DateProcessed { get; set; }
        public PropertyOwner PropertyOwner { get; set; }
        public PropertyStatus PropertyStatus { get; set; }


        public TitleDeed() {
            PropertyOwner = new PropertyOwner();
            PropertyStatus = new PropertyStatus();
        }
    }
}
