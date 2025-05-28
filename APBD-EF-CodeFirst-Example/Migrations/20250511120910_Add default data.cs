using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_EF_CodeFirst_Example.Migrations
{
    /// <inheritdoc />
    public partial class Adddefaultdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "16c" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Age", "EntranceExamScore", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 25, 70.2f, "John", "Doe" },
                    { 2, 20, null, "Jane", "Doe" }
                });

            migrationBuilder.InsertData(
                table: "GroupAssignment",
                columns: new[] { "Group_Id", "Student_Id" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupAssignment",
                keyColumns: new[] { "Group_Id", "Student_Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
