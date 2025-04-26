using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FabricaDeChocolate.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantidadeToTrufas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Embalagens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Embalagens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Trufas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Trufas");

            migrationBuilder.InsertData(
                table: "Embalagens",
                columns: new[] { "Id", "Cor", "QtdDisponivel", "QtdMinima", "Tamanho" },
                values: new object[,]
                {
                    { 1, "Amarelo", 200, 100, "4x8" },
                    { 2, "Azul", 430, 100, "5x10" }
                });
        }
    }
}
