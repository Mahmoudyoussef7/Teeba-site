namespace MVC_Teeba_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passenger", "National_ID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Passenger", "National_ID");
        }
    }
}
