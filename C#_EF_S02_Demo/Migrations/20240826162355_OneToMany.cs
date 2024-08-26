using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__EF_S02_Demo.Migrations
{
    /// <inheritdoc />
    public partial class OneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmpId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_EmpId",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "WorkForId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkForId",
                table: "Employees",
                column: "WorkForId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_WorkForId",
                table: "Employees",
                column: "WorkForId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_WorkForId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WorkForId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkForId",
                table: "Employees");

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
    }
}
