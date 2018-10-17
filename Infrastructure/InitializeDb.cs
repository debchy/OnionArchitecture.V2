using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Models;

namespace Infrastructure
{
    
    public class InitializeDb : DropCreateDatabaseAlways<DataBaseContext>
    {

        protected override void Seed(DataBaseContext context)
        {
            context.Domains.Add(
                new DomainCore.Models.Domain
                {
                    Id=1,
                    Name = "File Manager"
                });
            context.SaveChanges();
            context.Domains.Add(
                new Domain
                {
                    Id=2,
                    Name = "Media Manager"
                });
            context.SaveChanges();
            context.Contents.Add(
                new Content
                {                    
                    Name="Root",
                    ContentType= ContentType.Folder,
                    Domain= context.Domains.Find(1),
                    IsPublic=false,
                    OwnerId=1,
                    UpdateDate=DateTime.Now,
                    CreatedDate=DateTime.Now,
                    ParentContentId=null,                    
                    IsDeleted=false
                }
                );
            context.SaveChanges();
            context.Contents.Add(
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
            base.Seed(context);
        }
    }
}
