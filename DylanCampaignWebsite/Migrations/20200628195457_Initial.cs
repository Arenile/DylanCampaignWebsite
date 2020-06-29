using Microsoft.EntityFrameworkCore.Migrations;

namespace DylanCampaignWebsite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterName = table.Column<string>(nullable: true),
                    CharacterClass = table.Column<string>(nullable: true),
                    CharacterLevel = table.Column<int>(nullable: false),
                    CharacterRace = table.Column<string>(nullable: true),
                    CharacterBackground = table.Column<string>(nullable: true),
                    CharacterBio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
