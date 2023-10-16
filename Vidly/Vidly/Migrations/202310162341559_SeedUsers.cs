namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ed364f7a-b725-4a43-8bf3-de2f9face7db', N'admin@vidly.com', 0, N'AMS84U6NQibVK+gYUadGq0vTCT8u19Drjp2Se/LnXLJAgf9azz/I6gDr4lDJWSfLjw==', N'63f05a37-becb-48f8-b9f8-7b2ce8a6fee7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f021197e-d7b8-45eb-8bfa-67ee598f57a8', N'arda.ay@outlook.com.tr', 0, N'AIfmM4AXz1oV6ZJnZWk4hPJDfyV3NN1m567iEaXoxt48QYDWUK/lmso+6xapDWeHLg==', N'f01b0a7d-e491-4ccf-ad1a-94ac5b71877d', NULL, 0, 0, NULL, 1, 0, N'arda.ay@outlook.com.tr')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'86c8cebb-9522-403a-b9e1-df3be20568cb', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ed364f7a-b725-4a43-8bf3-de2f9face7db', N'86c8cebb-9522-403a-b9e1-df3be20568cb')

");
        }
        
        public override void Down()
        {
        }
    }
}
