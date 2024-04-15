using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Proveedor> Proveedores { get; set; } // Assuming Proveedor is your model class for providers

    // Add other DbSets for other entities as needed
}
