using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApi.Migrations
{
    public partial class MoviesMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Items",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Items",
                newName: "releaseDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Items",
                newName: "name");

            migrationBuilder.AddColumn<string>(
                name: "duration",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "genre",
                table: "Items",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "duration",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "genre",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Items",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "releaseDate",
                table: "Items",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Items",
                newName: "Description");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
