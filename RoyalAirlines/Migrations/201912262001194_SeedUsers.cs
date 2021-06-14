namespace RoyalAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c4704f7d-3fb5-46ad-8bad-9594446009bd', N'guest@royalairlines.com', 0, N'AF+WQTg9YvMKCSwqn4Ar/bA8pcznnN8P0xhP/da71Je96z5wCsxH8goWOnLOol5WOg==', N'066a6b90-ff6a-4a2c-af78-e9a6454ecd69', NULL, 0, 0, NULL, 1, 0, N'guest@royalairlines.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd08e008d-9a86-418f-868e-94aa08e2109a', N'admin@royalairlines.com', 0, N'AJZn7UrkI9PQRkbmuu+chEuOXeE1aHn6lBgpR7N7V4UrLPmJtHi8OaVCpNQThwAjYA==', N'317106f2-adac-4584-a6b0-cd1f88fa4713', NULL, 0, 0, NULL, 1, 0, N'admin@royalairlines.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9347a5ed-6234-4e4a-a88a-66f01c9b8978', N'Admin')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd08e008d-9a86-418f-868e-94aa08e2109a', N'9347a5ed-6234-4e4a-a88a-66f01c9b8978')

");
        }
        
        public override void Down()
        {
        }
    }
}
