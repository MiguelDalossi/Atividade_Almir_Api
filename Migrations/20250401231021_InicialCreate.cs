using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atividade_Almir_Api.Migrations
{
    /// <inheritdoc />
    public partial class InicialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modelo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    marca = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    cor = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    chassi = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motos");
        }
    }
}
