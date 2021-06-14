namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactValidationsAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Contacts", "Subject", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Subject", c => c.String());
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false));
        }
    }
}
