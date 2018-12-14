using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class userToSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectOwnerId",
                value: "337e7562-fd6c-43ff-8824-1b7cfee39a63");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectOwnerId",
                value: "337e7562-fd6c-43ff-8824-1b7cfee39a63");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectOwnerId",
                value: "337e7562-fd6c-43ff-8824-1b7cfee39a63");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectOwnerId",
                value: "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectOwnerId",
                value: "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectOwnerId",
                value: "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a");
        }
    }
}
