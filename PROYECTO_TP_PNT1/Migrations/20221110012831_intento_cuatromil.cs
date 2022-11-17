using Microsoft.EntityFrameworkCore.Migrations;

namespace PROYECTO_TP_PNT1.Migrations
{
    public partial class intento_cuatromil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alojamientos_Clientes_clienteid",
                table: "Alojamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Alojamientos_alojamientoid",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clinteid",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservas",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_alojamientoid",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_clinteid",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alojamientos",
                table: "Alojamientos");

            migrationBuilder.DropIndex(
                name: "IX_Alojamientos_clienteid",
                table: "Alojamientos");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "alojamientoid",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "clinteid",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Alojamientos");

            migrationBuilder.DropColumn(
                name: "clienteid",
                table: "Alojamientos");

            migrationBuilder.AddColumn<int>(
                name: "idReserva",
                table: "Reservas",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "alojamientoidAlojamiento",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clienteidCliente",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idAlojamiento",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Clientes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Alojamientos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Alojamientos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idAlojamiento",
                table: "Alojamientos",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<double>(
                name: "precio",
                table: "Alojamientos",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservas",
                table: "Reservas",
                column: "idReserva");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "idCliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alojamientos",
                table: "Alojamientos",
                column: "idAlojamiento");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservas",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_alojamientoidAlojamiento",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_clienteidCliente",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alojamientos",
                table: "Alojamientos");

            migrationBuilder.DropColumn(
                name: "idReserva",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "alojamientoidAlojamiento",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "clienteidCliente",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "idAlojamiento",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "idAlojamiento",
                table: "Alojamientos");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "Alojamientos");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "alojamientoid",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clinteid",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "precio",
                table: "Reservas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Alojamientos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Alojamientos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Alojamientos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "clienteid",
                table: "Alojamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservas",
                table: "Reservas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alojamientos",
                table: "Alojamientos",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_alojamientoid",
                table: "Reservas",
                column: "alojamientoid");

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
                name: "FK_Reservas_Alojamientos_alojamientoid",
                table: "Reservas",
                column: "alojamientoid",
                principalTable: "Alojamientos",
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
    }
}
