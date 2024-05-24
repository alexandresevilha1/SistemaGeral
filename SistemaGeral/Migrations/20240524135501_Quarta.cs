using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGeral.Migrations
{
    /// <inheritdoc />
    public partial class Quarta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proprietario",
                table: "Empresa");

            migrationBuilder.AddColumn<int>(
                name: "ProprietarioID",
                table: "Empresa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_ProprietarioID",
                table: "Empresa",
                column: "ProprietarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Funcionario_ProprietarioID",
                table: "Empresa",
                column: "ProprietarioID",
                principalTable: "Funcionario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Funcionario_ProprietarioID",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_ProprietarioID",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "ProprietarioID",
                table: "Empresa");

            migrationBuilder.AddColumn<string>(
                name: "Proprietario",
                table: "Empresa",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
