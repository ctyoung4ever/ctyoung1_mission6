using Microsoft.EntityFrameworkCore.Migrations;

namespace ctyoung1_mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action", "Steven Spielburg", false, "", "", "PG", "Troy", 1990 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Comedy", "Michael Bay", true, "Bob", "", "PG-13", "I am Legend", 2005 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Adventure", "Jessie Pinkman", false, "", "", "R", "Jumanji", 2015 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
