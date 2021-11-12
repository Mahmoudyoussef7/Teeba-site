namespace MVC_Teeba_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Passenger", "zzz");
            DropColumn("dbo.Passenger", "National_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Passenger", "National_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Passenger", "zzz", c => c.Int());
        }
    }
}
