﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp2.Models
{
    public class Child
    {
        public int ChildID { get; set; }
        public int AdvoID { get; set; }
        public int ProjectID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }

       
        public virtual ICollection<Parent> Parents { get; set; }
        

    }
}