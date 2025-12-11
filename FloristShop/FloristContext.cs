namespace FloristShop;
using Microsoft.EntityFrameworkCore;

public class FloristContext(DbContextOptions<FloristContext> options) : DbContext(options)
{
    public DbSet<Flower> MyProperty { get; set; }
}