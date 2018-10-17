namespace Infrastructure.Migrations.DataBaseContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StoredFileName = c.String(),
                        MediaTypeId = c.Int(),
                        DomainId = c.Int(nullable: false),
                        ContentType = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsPublic = c.Boolean(nullable: false),
                        OwnerId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        ParentContentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Domains", t => t.DomainId, cascadeDelete: true)
                .ForeignKey("dbo.Contents", t => t.ParentContentId)
                .Index(t => t.DomainId)
                .Index(t => t.ParentContentId);
            
            CreateTable(
                "dbo.Domains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "ParentContentId", "dbo.Contents");
            DropForeignKey("dbo.Contents", "DomainId", "dbo.Domains");
            DropIndex("dbo.Contents", new[] { "ParentContentId" });
            DropIndex("dbo.Contents", new[] { "DomainId" });
            DropTable("dbo.Domains");
            DropTable("dbo.Contents");
        }
    }
}
