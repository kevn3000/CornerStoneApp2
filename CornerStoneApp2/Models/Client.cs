using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp2.Models
{
    public class Client
    {
        public Guid clientID { get; set; }
       
        public DateTime dateAdd { get; set; }
        public string parent1First { get; set; }
        public string parent1Last { get; set; }
        public string parent2First { get; set; }
        public string parent2Last { get; set; }
        public string relationship { get; set; }
        public string studentFirst { get; set; }
        public string studentLast { get; set; }
        public string studentAge { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string currentSchool { get; set; }
        public string county { get; set; }
        public string grade { get; set; }
        public string primaryDiagnosis { get; set; }
        public string address { get; set; }
        public string streetAddress { get; set; }
        public string streetAddress2 { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        public string altEmail { get; set; }
        public string phone { get; set; }
        public string altPhone { get; set; }
        public string referredBy { get; set; }
        public Diagnoses primary { get; set; }
        public string secondaryDiagnosis { get; set; }
        public Diagnoses secondary { get; set; }
        public Diagnoses iep { get; set; }
        public string relatedServices { get; set; }
        public string outsideServices { get; set; }
        public string schoolHistory { get; set; }
        public string parentConcerns { get; set; }
        public string parentGoals { get; set; }
        public DateTime lastSchoolMeeting { get; set; }
        public string meetingType { get; set; }
        public string notes { get; set; }




    }
}