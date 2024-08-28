using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eManagement.Migrations
{
    /// <inheritdoc />
    public partial class cleancoloumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
             name: "Source",
             table: "eManagementLeadEntity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
