using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNET90_EFCORE03.Migrations
{
    /// <inheritdoc />
    public partial class FixingDataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Description", "InstructorId", "Price", "PublishDate", "Title" },
                values: new object[] { "Core principles of relational database design.", 1001, 59.99m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Database Design" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CategoryId", "Description", "Price", "PublishDate", "Title" },
                values: new object[] { 1002, "Build web applications with modern tools.", 69.99m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web Development" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CategoryId", "Description", "InstructorId", "IsPublished", "Price", "PublishDate", "Title" },
                values: new object[] { 1000, "An introduction to cloud platforms and services.", 1002, false, 79.99m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cloud Computing" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Description", "InstructorId", "Price", "PublishDate", "Title" },
                values: new object[] { "Design and build reliable web APIs.", 1000, 54.99m, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "API Development" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Description", "InstructorId", "Price", "PublishDate", "Title" },
                values: new object[] { "Learn software testing fundamentals and practices.", 1002, 44.99m, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Testing" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishDate", "Title" },
                values: new object[] { 1000, 1000, "Introduction to C# programming.", 1000, true, 0, 49.99m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# Fundamentals" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Description", "InstructorId", "Price", "PublishDate", "Title" },
                values: new object[] { "Introduction to C# programming.", 1000, 49.99m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# Fundamentals" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CategoryId", "Description", "Price", "PublishDate", "Title" },
                values: new object[] { 1000, "Core principles of relational database design.", 59.99m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Database Design" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CategoryId", "Description", "InstructorId", "IsPublished", "Price", "PublishDate", "Title" },
                values: new object[] { 1002, "Build web applications with modern tools.", 1001, true, 69.99m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web Development" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Description", "InstructorId", "Price", "PublishDate", "Title" },
                values: new object[] { "An introduction to cloud platforms and services.", 1002, 79.99m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cloud Computing" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Description", "InstructorId", "Price", "PublishDate", "Title" },
                values: new object[] { "Design and build reliable web APIs.", 1000, 54.99m, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "API Development" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishDate", "Title" },
                values: new object[] { 1006, 1000, "Learn software testing fundamentals and practices.", 1002, false, 0, 44.99m, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Testing" });
        }
    }
}
