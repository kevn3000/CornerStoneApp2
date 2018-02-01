using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CornerStoneApp2.Models;

namespace CornerStoneApp2.DAL
{
    public class CornerstoneInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CornerstoneContext>
    {
        protected override void Seed(CornerstoneContext context)
        {
            var advocates = new List<Advo>
            {
                new Advo {AdvoID = 1, FirstName = "Bill", LastName = "Williamson" },
                new Advo {AdvoID = 2, FirstName = "William", LastName = "Billington"}
            };

            advocates.ForEach(s => context.Advocates.Add(s));
            context.SaveChanges();

            var children = new List<Child>
            {
                new Child {ChildID = 11, Address = "123 Countingdale Lane", AdvoID = 1, FirstName = "Eden", LastName = "White", MidName = "Violet"  },
                new Child {ChildID = 12, Address = "2113 Pavington Road ", AdvoID = 2, FirstName = "Alexander", LastName = "White", MidName = "Jackson"}
            };

            children.ForEach(s => context.Children.Add(s));
            context.SaveChanges();
            
            var parents = new List<Parent>
            {
                new Parent {ParentID = 111, Address = "123 Countingdale Lane", FirstName = "Sarah", MidName = "Kelly", LastName = "White"},
                new Parent {ParentID = 112, Address = "2113 Pavington Road", FirstName = "Andrew", MidName = "Miller",LastName= "Jackson"}
            };

            parents.ForEach(s => context.Parents.Add(s));
            context.SaveChanges();

            var donors = new List<Donor>
            {
                new Donor {DonorID = 1111, Address = "1 Main Street", FirstName = "Johnny", LastName = "Deepockets", MidName = "Haveth"},
            };

            donors.ForEach(s => context.Donors.Add(s));
            context.SaveChanges();

            var projects = new List<Project>
            {
                new Project {AdvoID = 1, ChildID = 11, ProjectID = 11111 },
                new Project {AdvoID =2 , ChildID = 12, ProjectID = 11112 }
            };

            projects.ForEach(s => context.Projects.Add(s));
            context.SaveChanges();

        }
    }
}