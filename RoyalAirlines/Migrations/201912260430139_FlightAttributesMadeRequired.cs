namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlightAttributesMadeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Flights", "Code", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Flights", "Code", c => c.String());
        }
    }
}
