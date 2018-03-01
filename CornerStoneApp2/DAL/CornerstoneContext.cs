using CornerStoneApp2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CornerStoneApp2.DAL
{
    public class CornerstoneContext : DbContext
    {
        public CornerstoneContext() : base("CornerstoneContext")
        {

        }

        public DbSet <Child> Children { get; set; }
        public DbSet<Advo> Advocates { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Diagnoses> Diags { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
