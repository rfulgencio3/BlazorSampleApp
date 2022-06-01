using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSampleApp.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "This is some example for description to post with id equals 1", "Post 1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 2, "This is some example for description to post with id equals 2", "Post 2" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 3, "This is some example for description to post with id equals 3", "Post 3" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 4, "This is some example for description to post with id equals 4", "Post 4" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 5, "This is some example for description to post with id equals 5", "Post 5" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 6, "This is some example for description to post with id equals 6", "Post 6" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 7, "This is some example for description to post with id equals 7", "Post 7" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 8, "This is some example for description to post with id equals 8", "Post 8" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 9, "This is some example for description to post with id equals 9", "Post 9" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 10, "This is some example for description to post with id equals 10", "Post 10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
