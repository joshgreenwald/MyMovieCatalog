using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMovieCatalog.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<short>(type: "smallint", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Rating", "ReleaseYear", "Title" },
                values: new object[] { 1, "PG", (short)1977, "Star Wars: A New Hope" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Rating", "ReleaseYear", "Title" },
                values: new object[] { 2, "PG", (short)1980, "The Empire Strikes Back" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Rating", "ReleaseYear", "Title" },
                values: new object[] { 3, "PG", (short)1983, "Return of the Jedi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
