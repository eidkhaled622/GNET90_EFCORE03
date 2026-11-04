using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GNET90_EFCORE03.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Desc", "Name", "ParentID" },
                values: new object[,]
                {
                    { 1000, "Programming courses", "Programming", null },
                    { 1003, "Cloud computing courses", "Cloud Computing", null }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "Email", "FullName", "JoinDate" },
                values: new object[,]
                {
                    { 1000, "Computer science instructor", "alex.morgan@example.com", "Alex Morgan", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1001, "Software development instructor", "jamie.lee@example.com", "Jamie Lee", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1002, "Database instructor", "taylor.reed@example.com", "Taylor Reed", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Desc", "Name", "ParentID" },
                values: new object[,]
                {
                    { 1001, "Web development courses", "Web Development", 1000 },
                    { 1004, "Mobile development courses", "Mobile Development", 1000 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1001, 1000, "Introduction to C# programming.", 1000, true, 0, 49.99m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# Fundamentals" },
                    { 1002, 1000, "Core principles of relational database design.", 1001, true, 0, 59.99m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Database Design" },
                    { 1004, 1000, "An introduction to cloud platforms and services.", 1002, false, 0, 79.99m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cloud Computing" },
                    { 1005, 1000, "Design and build reliable web APIs.", 1000, false, 0, 54.99m, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "API Development" },
                    { 1006, 1000, "Learn software testing fundamentals and practices.", 1002, false, 0, 44.99m, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Testing" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Desc", "Name", "ParentID" },
                values: new object[] { 1002, "Database courses", "Databases", 1001 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishDate", "Title" },
                values: new object[] { 1003, 1002, "Build web applications with modern tools.", 1001, true, 0, 69.99m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web Development" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1000);
        }
    }
}
