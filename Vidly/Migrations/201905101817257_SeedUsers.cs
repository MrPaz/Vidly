namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'28f2f0d0-1560-400b-ad5f-bae6bbb28cec', N'guest@vidly.com', 0, N'ACBkDaX6EqsHoZAmfF2iYmntdok42eueKgqiAMsvqz6p/s9/DBEx9NEgFqQUDJF1bA==', N'a7edc998-1feb-42ec-a52c-802a864bd425', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd7c76808-1e11-4c05-8f67-19589ce3fd27', N'admin@vidly.com', 0, N'ADUgVAu9DkN+OVldL9r7AxpsvqWb7qmUpINqNejbZB/IFf5tiWCpIL92qVP7AiERqw==', N'99b06a4c-44bf-4a21-9b72-7fd0598a35b9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd19d1fbb-6acd-4d21-9d93-ed9d2729d122', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd7c76808-1e11-4c05-8f67-19589ce3fd27', N'd19d1fbb-6acd-4d21-9d93-ed9d2729d122')
");
        }
        
        public override void Down()
        {
        }
    }
}
