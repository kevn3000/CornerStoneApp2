using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp2.Models
{
    public class Diagnoses
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}