using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    idMovie = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    movieCode = table.Column<string>(maxLength: 20, nullable: false),
                    movieType = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 150, nullable: true),
                    unitPrice = table.Column<decimal>(nullable: false),
                    qtyInStock = table.Column<int>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.idMovie);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
