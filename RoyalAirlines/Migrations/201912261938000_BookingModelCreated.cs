namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookingModelCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateBooked = c.DateTime(nullable: false),
                        Flight_Id = c.Int(nullable: false),
                        Users_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.Flight_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Users_Id, cascadeDelete: true)
                .Index(t => t.Flight_Id)
                .Index(t => t.Users_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "Users_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Bookings", "Flight_Id", "dbo.Flights");
            DropIndex("dbo.Bookings", new[] { "Users_Id" });
            DropIndex("dbo.Bookings", new[] { "Flight_Id" });
            DropTable("dbo.Bookings");
        }
    }
}
