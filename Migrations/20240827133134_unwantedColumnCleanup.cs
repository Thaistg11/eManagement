using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eManagement.Migrations
{
    /// <inheritdoc />
    public partial class unwantedColumnCleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       migrationBuilder.
       DropColumn(name: "Source", table: "eManagementLeadEntity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
           name: "Source",
           table: "eManagementLeadEntity",
           type: "nvarchar(max)",
           nullable: true);
        }
    }
}
