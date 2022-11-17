using Microsoft.EntityFrameworkCore.Migrations;

namespace PROYECTO_TP_PNT1.Migrations
{
    public partial class relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Reservas_reservaid",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_reservaid",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "reservaid",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "clinteid",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Clientes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dni",
                table: "Clientes",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "apellido",
                table: "Clientes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clienteid",
                table: "Alojamientos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_clinteid",
                table: "Reservas",
                column: "clinteid");

            migrationBuilder.CreateIndex(
                name: "IX_Alojamientos_clienteid",
                table: "Alojamientos",
                column: "clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Alojamientos_Clientes_clienteid",
                table: "Alojamientos",
                column: "clienteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_clinteid",
                table: "Reservas",
                column: "clinteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alojamientos_Clientes_clienteid",
                table: "Alojamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clinteid",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_clinteid",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Alojamientos_clienteid",
                table: "Alojamientos");

            migrationBuilder.DropColumn(
                name: "clinteid",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "clienteid",
                table: "Alojamientos");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "dni",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "apellido",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "reservaid",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_reservaid",
                table: "Clientes",
                column: "reservaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Reservas_reservaid",
                table: "Clientes",
                column: "reservaid",
                principalTable: "Reservas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
