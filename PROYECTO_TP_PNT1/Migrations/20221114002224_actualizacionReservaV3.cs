using Microsoft.EntityFrameworkCore.Migrations;

namespace PROYECTO_TP_PNT1.Migrations
{
    public partial class actualizacionReservaV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "alojamientoidAlojamiento",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clienteidCliente",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Reservas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_alojamientoidAlojamiento",
                table: "Reservas",
                column: "alojamientoidAlojamiento");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_clienteidCliente",
                table: "Reservas",
                column: "clienteidCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Alojamientos_alojamientoidAlojamiento",
                table: "Reservas",
                column: "alojamientoidAlojamiento",
                principalTable: "Alojamientos",
                principalColumn: "idAlojamiento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_clienteidCliente",
                table: "Reservas",
                column: "clienteidCliente",
                principalTable: "Clientes",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Alojamientos_alojamientoidAlojamiento",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clienteidCliente",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_alojamientoidAlojamiento",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_clienteidCliente",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "alojamientoidAlojamiento",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "clienteidCliente",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Reservas");
        }
    }
}
