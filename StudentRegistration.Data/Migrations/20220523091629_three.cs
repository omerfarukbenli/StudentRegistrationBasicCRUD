using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRegistration.Data.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lise", null });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortaokul", null });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İlkokul", null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedDate", "FirsName", "LastName", "SchooldId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5934), "ahmet", "veli", 1, null },
                    { 2, new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5943), "ali", "erdal", 2, null },
                    { 3, new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5944), "murat", "vural", 1, null },
                    { 4, new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5944), "volkan", "arda", 3, null },
                    { 5, new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5945), "atakan", "dural", 2, null }
                });

            migrationBuilder.InsertData(
                table: "StudentFeatures",
                columns: new[] { "Id", "Age", "Height", "StudentId" },
                values: new object[] { 1, 10, 150, 1 });

            migrationBuilder.InsertData(
                table: "StudentFeatures",
                columns: new[] { "Id", "Age", "Height", "StudentId" },
                values: new object[] { 2, 12, 140, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentFeatures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentFeatures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
