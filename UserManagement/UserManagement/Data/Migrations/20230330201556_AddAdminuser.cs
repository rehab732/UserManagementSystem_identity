using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Data.Migrations
{
    public partial class AddAdminuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled],[AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'e57036f67ac7',N'm',N'M',N'm@gmail.com',N'M@GMAIL.COM',0,N'AQAAAAEAACcQAAAAELcfLhKcjMblX6jNlwC7PHsH2yhrCtBukGKZeHBs/Dc3cxWfMCJarJZqGATjJX9pWg==',N'J4ZGZW6NPQPTKZZV5LUVJNTV4WDSTJ56',N'c8218768-4938-4c80-8911-ddfe8c34d6c3',NULL,0,0,NULL,1,0,N'Mahmoud',N'Mohammed',Null)");
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id ='e57036f67ac7'"); 

        }
    }
}
