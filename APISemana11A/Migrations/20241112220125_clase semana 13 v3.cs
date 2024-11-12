using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APISemana11A.Migrations
{
    /// <inheritdoc />
    public partial class clasesemana13v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Invoices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Customers");
        }
    }
}
