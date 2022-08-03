using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class DevPlaceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userModels",
                columns: table => new
                {
                    idUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passwordUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userModels", x => x.idUser);
                });

            migrationBuilder.CreateTable(
                name: "vehicleModels",
                columns: table => new
                {
                    idVehicle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marcaAutomovil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modeloAutomovil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    añoAutomovil = table.Column<int>(type: "int", nullable: false),
                    kilometrosAutomovil = table.Column<int>(type: "int", nullable: false),
                    precioAutomovil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleModels", x => x.idVehicle);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userModels");

            migrationBuilder.DropTable(
                name: "vehicleModels");
        }
    }
}
