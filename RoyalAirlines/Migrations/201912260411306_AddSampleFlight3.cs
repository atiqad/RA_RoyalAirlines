namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSampleFlight3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "Destination", c => c.String());
            DropColumn("dbo.Flights", "To");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Flights", "To", c => c.String());
            DropColumn("dbo.Flights", "Destination");
        }
    }
}
