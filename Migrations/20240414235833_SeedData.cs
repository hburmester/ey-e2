using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "Id", "RazonSocial", "NombreComercial", "IdentificacionTributaria", "NumeroTelefonico", "CorreoElectronico", "SitioWeb", "DireccionFisica", "Pais", "FacturacionAnualUSD", "UltimaEdicion" },
                values: new object[,]
                {
                    { 1, "Proveedor 1", "Comercial 1", 1234567891, "123-456-7890", "proveedor1@example.com", "http://www.proveedor1.com", "Dirección 1", "País 1", 10000.00m, DateTime.Now },
                    { 2, "Proveedor 2", "Comercial 2", 1234567892, "123-456-7891", "proveedor2@example.com", "http://www.proveedor2.com", "Dirección 2", "País 2", 20000.00m, DateTime.Now },
                    { 3, "Proveedor 3", "Comercial 3", 1234567893, "123-456-7892", "proveedor3@example.com", "http://www.proveedor3.com", "Dirección 3", "País 3", 30000.00m, DateTime.Now },
                    { 4, "Proveedor 4", "Comercial 4", 1234567894, "123-456-7893", "proveedor4@example.com", "http://www.proveedor4.com", "Dirección 4", "País 4", 40000.00m, DateTime.Now },
                    { 5, "Proveedor 5", "Comercial 5", 1234567895, "123-456-7894", "proveedor5@example.com", "http://www.proveedor5.com", "Dirección 5", "País 5", 50000.00m, DateTime.Now },
                    { 6, "Proveedor 6", "Comercial 6", 1234567896, "123-456-7895", "proveedor6@example.com", "http://www.proveedor6.com", "Dirección 6", "País 6", 60000.00m, DateTime.Now },
                    { 7, "Proveedor 7", "Comercial 7", 1234567897, "123-456-7896", "proveedor7@example.com", "http://www.proveedor7.com", "Dirección 7", "País 7", 70000.00m, DateTime.Now },
                    { 8, "Proveedor 8", "Comercial 8", 1234567898, "123-456-7897", "proveedor8@example.com", "http://www.proveedor8.com", "Dirección 8", "País 8", 80000.00m, DateTime.Now },
                    { 9, "Proveedor 9", "Comercial 9", 1234567899, "123-456-7898", "proveedor9@example.com", "http://www.proveedor9.com", "Dirección 9", "País 9", 90000.00m, DateTime.Now },
                    { 10, "Proveedor 10", "Comercial 10", 1234567800, "123-456-7899", "proveedor10@example.com", "http://www.proveedor10.com", "Dirección 10", "País 10", 100000.00m, DateTime.Now }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
            table: "Proveedores",
            keyColumn: "Id",
            keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }
    }
}
