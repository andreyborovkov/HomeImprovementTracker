using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class dataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectOwnerId",
                value: "ec8ee904-0427-43ee-8468-ed5700fa4c32");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectOwnerId",
                value: "ec8ee904-0427-43ee-8468-ed5700fa4c32");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectOwnerId",
                value: "ec8ee904-0427-43ee-8468-ed5700fa4c32");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "ProjectOwnerId",
                value: "ec8ee904-0427-43ee-8468-ed5700fa4c32");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "ProjectOwnerId",
                value: "337e7562-fd6c-43ff-8824-1b7cfee39a63");
        }
    }
}
