namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add3SampleFlights : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Flights (Code, Time, Origin, Destination, seatsEmpty) VALUES ('PK-353', 1/1/2020, 'Karachi', 'Islamabad', 150)");
            Sql("INSERT INTO Flights (Code, Time, Origin, Destination, seatsEmpty) VALUES ('PK-354', 2/1/2020, 'Islamabad', 'Karachi', 150)");
            Sql("INSERT INTO Flights (Code, Time, Origin, Destination, seatsEmpty) VALUES ('PK-355', 3/1/2020, 'Karachi', 'Islamabad', 150)");
        }
        
        public override void Down()
        {
        }
    }
}
