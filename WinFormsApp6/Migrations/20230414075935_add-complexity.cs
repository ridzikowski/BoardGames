using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp6.Migrations
{
    /// <inheritdoc />
    public partial class addcomplexity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Complexity",
                table: "GameBoards",
                type: "REAL",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Complexity",
                table: "GameBoards");
        }
    }
}
