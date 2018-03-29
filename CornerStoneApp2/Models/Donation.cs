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
        public Guid DonationID { get; set; }
        public float Amount { get; set; }
        public string donorFirst{get; set;}
        public string donorLast { get; set; }
        public string donorZip { get; set; }

    }
}