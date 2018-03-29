using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp2.Models
{
    public class Donor
    {
        public Guid DonorID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
       
        public string Address { get; set; } 
        public ICollection<Donation>Donations { get; set; }

    }
}