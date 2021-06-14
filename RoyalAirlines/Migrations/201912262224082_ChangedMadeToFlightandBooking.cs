namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMadeToFlightandBooking : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "seatsLeft", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Flights", "seatsLeft");
        }
    }
}
