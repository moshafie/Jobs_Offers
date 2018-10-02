namespace taske_tracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addjobtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                        CategoryDiscription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTitel = c.String(),
                        JobContent = c.String(),
                        JobImage = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "CategoryId", "dbo.categories");
            DropIndex("dbo.Jobs", new[] { "CategoryId" });
            DropTable("dbo.Jobs");
            DropTable("dbo.categories");
        }
    }
}
