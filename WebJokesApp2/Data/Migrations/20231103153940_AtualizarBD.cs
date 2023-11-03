using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebJokesApp2.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "Jokes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Jokes");
        }
    }
}
