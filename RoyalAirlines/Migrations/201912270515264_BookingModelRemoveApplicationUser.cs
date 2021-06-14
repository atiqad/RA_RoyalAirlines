namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookingModelRemoveApplicationUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "Users_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Bookings", new[] { "Users_Id" });
            DropColumn("dbo.Bookings", "Users_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "Users_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Bookings", "Users_Id");
            AddForeignKey("dbo.Bookings", "Users_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
