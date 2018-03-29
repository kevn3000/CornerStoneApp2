using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp2.Models
{
    public class Project
    {
        public Guid ProjectID { get; set; }
       
        // [DisplayName("Project Manager")]
        public Advo projectManager { get; set; }
        public DateTime startDate { get; set; }
        public Client client { get; set; }
        public string studentName { get; set; }
        public Boolean Active { get; set; }
        public string Status { get; set; }
        public int totalHours { get; set; }



    }
}