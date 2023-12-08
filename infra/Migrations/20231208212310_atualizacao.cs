using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infra.Migrations
{
    /// <inheritdoc />
    public partial class atualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescricaoBeneficios",
                table: "Vaga",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RequisitosComportamentais",
                table: "Vaga",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RequisitosTecnicos",
                table: "Vaga",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Responsabilidades",
                table: "Vaga",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescricaoBeneficios",
                table: "Vaga");

            migrationBuilder.DropColumn(
                name: "RequisitosComportamentais",
                table: "Vaga");

            migrationBuilder.DropColumn(
                name: "RequisitosTecnicos",
                table: "Vaga");

            migrationBuilder.DropColumn(
                name: "Responsabilidades",
                table: "Vaga");
        }
    }
}
