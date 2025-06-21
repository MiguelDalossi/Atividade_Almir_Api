using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atividade_Almir_Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNomeFromEncomendaMoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "EncomendaMotos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "EncomendaMotos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
