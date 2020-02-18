using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Facturacion.API.Migrations
{
    public partial class InitialCreateMigration_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "facturacion");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agencias",
                schema: "facturacion",
                columns: table => new
                {
                    AgenciaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    //Id = table.Column<int>(nullable: false),
                    ProveedorId = table.Column<int>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    Banco = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Cuenta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencias", x => x.AgenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Comisiones",
                schema: "facturacion",
                columns: table => new
                {
                    ComisionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    //Id = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    NotaFiscalId = table.Column<int>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    DateEmision = table.Column<DateTime>(nullable: false),
                    DatePago = table.Column<DateTime>(nullable: false),
                    Pax = table.Column<string>(nullable: true),
                    Facturacion = table.Column<int>(nullable: false),
                    Porcentaje = table.Column<decimal>(nullable: false),
                    Valor = table.Column<float>(nullable: false),
                    Tipo = table.Column<string>(maxLength: 100, nullable: false),
                    Voucher = table.Column<string>(maxLength: 50, nullable: false),
                    Agencia = table.Column<string>(maxLength: 150, nullable: false),
                    Orden = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comisiones", x => x.ComisionId);
                });

            migrationBuilder.CreateTable(
                name: "NotasFiscales",
                schema: "facturacion",
                columns: table => new
                {
                    NotaFiscalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    //Id = table.Column<int>(nullable: false),
                    DateEnvio = table.Column<DateTime>(nullable: false),
                    Empresa = table.Column<string>(nullable: true),
                    NroNota = table.Column<string>(nullable: true),
                    DateRechazo = table.Column<DateTime>(nullable: false),
                    DatePago = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasFiscales", x => x.NotaFiscalId);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                schema: "facturacion",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    //Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ProveedorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Agencias",
                schema: "facturacion");

            migrationBuilder.DropTable(
                name: "Comisiones",
                schema: "facturacion");

            migrationBuilder.DropTable(
                name: "NotasFiscales",
                schema: "facturacion");

            migrationBuilder.DropTable(
                name: "Proveedores",
                schema: "facturacion");
        }
    }
}
