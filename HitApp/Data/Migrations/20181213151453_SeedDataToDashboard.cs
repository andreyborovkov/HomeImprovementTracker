using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class SeedDataToDashboard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                column: "ExpenseDatePurchased",
                value: new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 2,
                column: "ExpenseDatePurchased",
                value: new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 3,
                column: "ExpenseDatePurchased",
                value: new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 4,
                column: "ExpenseDatePurchased",
                value: new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 5,
                column: "ExpenseDatePurchased",
                value: new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 6,
                column: "ExpenseDatePurchased",
                value: new DateTime(2018, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 7,
                column: "ExpenseDatePurchased",
                value: new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 9,
                column: "ExpenseDatePurchased",
                value: new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "ExpenseCost", "ExpenseDatePurchased", "ExpenseName", "ExpenseNotes", "ProductUrl", "ProjectId" },
                values: new object[] { 10, 1970.68, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "total expenses labor", "", null, 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectIsOnDashboard",
                value: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectDescription", "ProjectEndDate", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { "Paint and re-tile bathroom walls and floors. New toilet and small corner vanity.", new DateTime(2018, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Downstairs Bathroom", new DateTime(2018, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2400.0 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "ProjectDescription", "ProjectIsOnDashboard", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { "Paint and re-finish wood floors. Electricty in island and other new appliances", true, "Kitchen", new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000.0 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectDescription", "ProjectEndDate", "ProjectIsOnDashboard", "ProjectName", "ProjectOwnerId", "ProjectStartDate", "ProjectTotalBudget", "ProjectTotalExpenses" },
                values: new object[] { 4, "Take out part of basement wall, add baseboard heaters", new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Basement", "337e7562-fd6c-43ff-8824-1b7cfee39a63", new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 8,
                columns: new[] { "ExpenseDatePurchased", "ProjectId" },
                values: new object[] { new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                column: "ExpenseDatePurchased",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 2,
                column: "ExpenseDatePurchased",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 3,
                column: "ExpenseDatePurchased",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 4,
                column: "ExpenseDatePurchased",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 5,
                column: "ExpenseDatePurchased",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 6,
                column: "ExpenseDatePurchased",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 7,
                column: "ExpenseDatePurchased",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 8,
                columns: new[] { "ExpenseDatePurchased", "ProjectId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 9,
                column: "ExpenseDatePurchased",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectIsOnDashboard",
                value: false);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectDescription", "ProjectEndDate", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { "Paint and re-finish wood floors. Electricty in island and other new appliances", new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitchen", new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000.0 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "ProjectDescription", "ProjectIsOnDashboard", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { "Take out part of basement wall, add baseboard heaters", false, "Basement", new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500.0 });
        }
    }
}
