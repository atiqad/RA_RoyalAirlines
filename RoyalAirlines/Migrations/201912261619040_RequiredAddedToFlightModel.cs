namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredAddedToFlightModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Flights", "Origin", c => c.String(nullable: false));
            AlterColumn("dbo.Flights", "Destination", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Flights", "Destination", c => c.String());
            AlterColumn("dbo.Flights", "Origin", c => c.String());
        }
    }
}
