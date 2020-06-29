using Microsoft.EntityFrameworkCore.Migrations;

namespace DylanCampaignWebsite.Migrations
{
    public partial class revisedInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Acrobatics",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AnimalHandling",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Arcana",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArmorClass",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Athletics",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Charisma",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharismaSavingThrow",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Constitution",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConstitutionSavingThrow",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deception",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dexterity",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DexteritySavingThrow",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "History",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Initiative",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Insight",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intelligence",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntelligenceSavingThrow",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intimidation",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Investigation",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxHealth",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Medicine",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nature",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Perception",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Performance",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Persuasion",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Religion",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SleightOfHand",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stealth",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StrengthSavingThrow",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Survival",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wisdom",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WisdomSavingThrow",
                table: "Characters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acrobatics",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AnimalHandling",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Arcana",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ArmorClass",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Athletics",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Charisma",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharismaSavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Constitution",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ConstitutionSavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Deception",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Dexterity",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "DexteritySavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Initiative",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Insight",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Intelligence",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IntelligenceSavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Intimidation",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Investigation",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "MaxHealth",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Medicine",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Nature",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Perception",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Performance",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Persuasion",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SleightOfHand",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stealth",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StrengthSavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Survival",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Wisdom",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "WisdomSavingThrow",
                table: "Characters");
        }
    }
}
