using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CornerStoneApp2.Models
{
    public class Donation
    {
        //[Key]
        public int DonationID { get; set; }
        public float Amount {get; set;}
        public int DonorID { get; set; }
    }
}