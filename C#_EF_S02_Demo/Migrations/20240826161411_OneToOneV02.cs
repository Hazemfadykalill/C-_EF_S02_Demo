using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__EF_S02_Demo.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneV02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Departments",
                newName: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmpId",
                table: "Departments",
                column: "EmpId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_EmpId",
                table: "Departments",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmpId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_EmpId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Departments",
                newName: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                table: "Departments",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
