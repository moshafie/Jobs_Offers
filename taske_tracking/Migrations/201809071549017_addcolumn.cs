namespace taske_tracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "usertype", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "usertype");
        }
    }
}
