using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpefplayers.Migrations
{
    /// <inheritdoc />
    public partial class Milestone2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    NameTeam = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.NameTeam);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    score = table.Column<double>(type: "float", nullable: false),
                    GamePlayed = table.Column<int>(type: "int", nullable: false),
                    GameWon = table.Column<int>(type: "int", nullable: false),
                    NameTeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamNameTeam = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Teams_TeamNameTeam",
                        column: x => x.TeamNameTeam,
                        principalTable: "Teams",
                        principalColumn: "NameTeam");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_Id",
                table: "Player",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamNameTeam",
                table: "Player",
                column: "TeamNameTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_NameTeam",
                table: "Teams",
                column: "NameTeam",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
