using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eManagement.Migrations
{
    /// <inheritdoc />
    public partial class CreatingRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "eManagementLeadEntity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_eManagementLeadEntity_DepartmentId",
                table: "eManagementLeadEntity",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_eManagementLeadEntity_Department_DepartmentId",
                table: "eManagementLeadEntity",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eManagementLeadEntity_Department_DepartmentId",
                table: "eManagementLeadEntity");

            migrationBuilder.DropIndex(
                name: "IX_eManagementLeadEntity_DepartmentId",
                table: "eManagementLeadEntity");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "eManagementLeadEntity");
        }
    }
}
