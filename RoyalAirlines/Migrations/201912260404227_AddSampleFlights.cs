namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSampleFlights : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "Origin", c => c.String());
            DropColumn("dbo.Flights", "From");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Flights", "From", c => c.String());
            DropColumn("dbo.Flights", "Origin");
        }
    }
}
