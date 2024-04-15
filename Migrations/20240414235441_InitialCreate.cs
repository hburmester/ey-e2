using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RazonSocial = table.Column<string>(type: "longtext", nullable: false),
                    NombreComercial = table.Column<string>(type: "longtext", nullable: false),
                    IdentificacionTributaria = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    NumeroTelefonico = table.Column<string>(type: "longtext", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "longtext", nullable: false),
                    SitioWeb = table.Column<string>(type: "longtext", nullable: false),
                    DireccionFisica = table.Column<string>(type: "longtext", nullable: false),
                    Pais = table.Column<string>(type: "longtext", nullable: false),
                    FacturacionAnualUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UltimaEdicion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
