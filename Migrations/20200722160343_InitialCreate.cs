using Microsoft.EntityFrameworkCore.Migrations;

namespace NBA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    playerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    playerName = table.Column<string>(nullable: false),
                    playerNumber = table.Column<string>(nullable: false),
                    teamName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.playerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
