using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HK.Lawand.Learnings.DataService.Migrations
{
    /// <inheritdoc />
    public partial class secondmigrationmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListedCount",
                table: "PublicMetrics",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListedCount",
                table: "PublicMetrics");
        }
    }
}
