namespace NewVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4ebcc571-b7ac-424a-96e7-310b3259c9ff', N'guest@vidly.com', 0, N'AEHRxXhX74i7+EhtvBKu1CGyLgL9oAaxQ7jYhxVXG/vXurAkOYZETbbPHKmS4hS4vQ==', N'faa8bb76-9ef4-4832-bd53-4880914a443b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd33beee9-e6eb-47eb-8a3e-9664720eb5c0', N'admin@vidly.com', 0, N'ANLf/6KEurdI1fa+6BDmXIayGnfcuSeTviSHFFd+vdGAyizSGptkjGknWjA0dCC9jQ==', N'612f54c8-649a-4ec6-8073-304d2d2838c6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'47c93996-4069-4a2d-88d0-5dba4b249728', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd33beee9-e6eb-47eb-8a3e-9664720eb5c0', N'47c93996-4069-4a2d-88d0-5dba4b249728')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
