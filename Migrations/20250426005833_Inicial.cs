using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FabricaDeChocolate.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Embalagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tamanho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QtdDisponivel = table.Column<int>(type: "int", nullable: false),
                    QtdMinima = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embalagens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trufas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmbalagemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trufas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trufas_Embalagens_EmbalagemId",
                        column: x => x.EmbalagemId,
                        principalTable: "Embalagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Embalagens",
                columns: new[] { "Id", "Cor", "QtdDisponivel", "QtdMinima", "Tamanho" },
                values: new object[,]
                {
                    { 1, "Amarelo", 200, 100, "4x8" },
                    { 2, "Azul", 430, 100, "5x10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trufas_EmbalagemId",
                table: "Trufas",
                column: "EmbalagemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trufas");

            migrationBuilder.DropTable(
                name: "Embalagens");
        }
    }
}
