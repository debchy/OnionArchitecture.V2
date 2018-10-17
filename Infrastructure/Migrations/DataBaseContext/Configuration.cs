namespace Infrastructure.Migrations.DataBaseContext
{
    using DomainCore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.DataBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\DataBaseContext";
        }

        protected override void Seed(Infrastructure.DataBaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Domains.AddOrUpdate(
                new DomainCore.Models.Domain
                {
                    Id = 1,
                    Name = "File Manager"
                });
            context.SaveChanges();
            context.Domains.AddOrUpdate(
                new Domain
                {
                    Id = 2,
                    Name = "Media Manager"
                });
            context.SaveChanges();
            context.Contents.AddOrUpdate(
                new Content
                {
                    Name = "Root",
                    ContentType = ContentType.Folder,
                    Domain = context.Domains.Find(1),
                    IsPublic = false,
                    OwnerId = 1,
                    UpdateDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    ParentContentId = null,
                    IsDeleted = false
                }
                );
            context.SaveChanges();
            context.Contents.AddOrUpdate(
                new Content
                {
                    Name = "Root",
                    ContentType = ContentType.Folder,
                    Domain = context.Domains.Find(2),
                    IsPublic = false,
                    OwnerId = 1,
                    UpdateDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    ParentContentId = null,
                    IsDeleted = false
                }
                );
            context.SaveChanges();
        }
    }
}
