namespace MVC_Teeba_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passenger", "zzz", c => c.Int());
            DropColumn("dbo.Passenger", "SS");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Passenger", "SS", c => c.Int(nullable: false));
            DropColumn("dbo.Passenger", "zzz");
        }
    }
}
