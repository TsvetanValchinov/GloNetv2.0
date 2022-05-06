using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class NewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserID1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserID1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserID1",
                table: "Posts",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserID1",
                table: "Posts",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
