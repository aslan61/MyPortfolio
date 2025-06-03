using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolio.Migrations
{
    public partial class mig_adress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Contacts",
                newName: "adress2");

            migrationBuilder.RenameColumn(
                name: "Phone2",
                table: "Contacts",
                newName: "adress1");

            migrationBuilder.RenameColumn(
                name: "Email2",
                table: "Contacts",
                newName: "PostaKodu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "adress2",
                table: "Contacts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "adress1",
                table: "Contacts",
                newName: "Phone2");

            migrationBuilder.RenameColumn(
                name: "PostaKodu",
                table: "Contacts",
                newName: "Email2");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
