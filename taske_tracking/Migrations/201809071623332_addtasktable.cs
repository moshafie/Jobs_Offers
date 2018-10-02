namespace taske_tracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtasktable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false),
                        details = c.String(nullable: false),
                        assingname = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskTables");
        }
    }
}
