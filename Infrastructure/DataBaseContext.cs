using DomainCore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext()
            : base(System.Configuration.ConfigurationManager.
                ConnectionStrings["DefaultConnection"].ConnectionString)
        {

        }


        public DbSet<Domain> Domains { get; set; }
        public DbSet<Content> Contents { get; set; }

        public static DataBaseContext Create()
        {

            return new DataBaseContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Configure FileID as FK for StudentAddress
            //modelBuilder.Entity<File>()
            //            .HasRequired(s => s.MediaType)
            //            .WithRequiredPrincipal(ad => ad.File); //one to one relationship
            
        }
    }
}
