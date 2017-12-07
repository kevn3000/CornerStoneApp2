namespace CornerStoneApp2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationContext : DbContext
    {
        // Your context has been configured to use a 'Advocate' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CornerStoneApp2.Models.Advocate' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Advocate' 
        // connection string in the application configuration file.
        public ApplicationContext()
            : base("name=DefaultConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Advocate> Advocates { get; set; }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Advocate {

        [Key]
        public string MyId { get; set; }
        public string Tasks { get; set; }
        public string PhoneNumber { get; set; }
    }
}