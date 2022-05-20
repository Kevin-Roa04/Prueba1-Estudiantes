using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistematico.Domain.Migrations
{
    public partial class PepitoSchool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Carnet = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    Phone = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Correo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Matematica = table.Column<int>(type: "int", nullable: false),
                    Contabilidad = table.Column<int>(type: "int", nullable: false),
                    Programacion = table.Column<int>(type: "int", nullable: false),
                    Estadistica = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
