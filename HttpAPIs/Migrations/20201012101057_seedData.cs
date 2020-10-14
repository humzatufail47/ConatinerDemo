using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HttpAPIs.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { new Guid("b3ceee8d-f995-4d75-8c23-7fd293f460c5"), 25, "Humza", "Male", "Tufail" },
                    { new Guid("c3110344-691a-493a-ab11-bb19b6b43be8"), 25, "Salman", "Male", "AK" },
                    { new Guid("3af2a713-881c-4613-bb51-032fbea1bb25"), 25, "Hadid", "Male", "Bushra" },
                    { new Guid("0abd785e-73cb-4652-8ab4-507637fcf12c"), 25, "Zeeshan", "Male", "Maaao" },
                    { new Guid("7da3c572-fc78-4ce0-a0d3-6a169861119b"), 25, "Amaid", "Male", "Haider" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0abd785e-73cb-4652-8ab4-507637fcf12c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3af2a713-881c-4613-bb51-032fbea1bb25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7da3c572-fc78-4ce0-a0d3-6a169861119b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3ceee8d-f995-4d75-8c23-7fd293f460c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3110344-691a-493a-ab11-bb19b6b43be8"));
        }
    }
}
