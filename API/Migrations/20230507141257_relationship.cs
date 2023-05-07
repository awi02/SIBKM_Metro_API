using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "education_id",
                table: "tb_tr_profilings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "university_id",
                table: "tb_tr_educations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_profilings_education_id",
                table: "tb_tr_profilings",
                column: "education_id",
                unique: true,
                filter: "[education_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_educations_university_id",
                table: "tb_tr_educations",
                column: "university_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_account_roles_account_nik",
                table: "tb_tr_account_roles",
                column: "account_nik");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_account_roles_role_id",
                table: "tb_tr_account_roles",
                column: "role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_account_roles_tb_tr_accounts_account_nik",
                table: "tb_tr_account_roles",
                column: "account_nik",
                principalTable: "tb_tr_accounts",
                principalColumn: "employee_nik");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_account_roles_tb_tr_role_role_id",
                table: "tb_tr_account_roles",
                column: "role_id",
                principalTable: "tb_tr_role",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_accounts_tb_m_employees_employee_nik",
                table: "tb_tr_accounts",
                column: "employee_nik",
                principalTable: "tb_m_employees",
                principalColumn: "nik",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_educations_tb_tr_Universities_university_id",
                table: "tb_tr_educations",
                column: "university_id",
                principalTable: "tb_tr_Universities",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_profilings_tb_m_employees_employee_nik",
                table: "tb_tr_profilings",
                column: "employee_nik",
                principalTable: "tb_m_employees",
                principalColumn: "nik",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_profilings_tb_tr_educations_education_id",
                table: "tb_tr_profilings",
                column: "education_id",
                principalTable: "tb_tr_educations",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_account_roles_tb_tr_accounts_account_nik",
                table: "tb_tr_account_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_account_roles_tb_tr_role_role_id",
                table: "tb_tr_account_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_accounts_tb_m_employees_employee_nik",
                table: "tb_tr_accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_educations_tb_tr_Universities_university_id",
                table: "tb_tr_educations");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_profilings_tb_m_employees_employee_nik",
                table: "tb_tr_profilings");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_profilings_tb_tr_educations_education_id",
                table: "tb_tr_profilings");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_profilings_education_id",
                table: "tb_tr_profilings");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_educations_university_id",
                table: "tb_tr_educations");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_account_roles_account_nik",
                table: "tb_tr_account_roles");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_account_roles_role_id",
                table: "tb_tr_account_roles");

            migrationBuilder.AlterColumn<int>(
                name: "education_id",
                table: "tb_tr_profilings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "university_id",
                table: "tb_tr_educations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
