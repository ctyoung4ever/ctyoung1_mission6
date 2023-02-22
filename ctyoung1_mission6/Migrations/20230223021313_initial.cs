using Microsoft.EntityFrameworkCore.Migrations;

namespace ctyoung1_mission6.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingID);
                });

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
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    RatingID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_responses_Rating_RatingID",
                        column: x => x.RatingID,
                        principalTable: "Rating",
                        principalColumn: "RatingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "Category", "Director", "Edited", "Lent", "Notes", "RatingID", "Title", "Year" },
                values: new object[] { 1, "Action", "Steven Spielburg", false, "", "", 1, "Troy", 1990 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "Category", "Director", "Edited", "Lent", "Notes", "RatingID", "Title", "Year" },
                values: new object[] { 2, "Comedy", "Michael Bay", true, "Bob", "", 2, "I am Legend", 2005 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "Category", "Director", "Edited", "Lent", "Notes", "RatingID", "Title", "Year" },
                values: new object[] { 3, "Adventure", "Jessie Pinkman", false, "", "", 3, "Jumanji", 2015 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_RatingID",
                table: "responses",
                column: "RatingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Rating");
        }
    }
}
