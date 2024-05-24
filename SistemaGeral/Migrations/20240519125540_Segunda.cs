using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGeral.Migrations
{
    /// <inheritdoc />
    public partial class Segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cargo",
                table: "Funcionario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Funcionario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaID",
                table: "Funcionario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Funcionario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "SalarioBase",
                table: "Funcionario",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Funcionario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<int>(type: "int", nullable: false),
                    Proprietario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_EmpresaID",
                table: "Funcionario",
                column: "EmpresaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Empresa_EmpresaID",
                table: "Funcionario",
                column: "EmpresaID",
                principalTable: "Empresa",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Empresa_EmpresaID",
                table: "Funcionario");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_EmpresaID",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "EmpresaID",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "SalarioBase",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Funcionario");
        }
    }
}
