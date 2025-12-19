namespace FloristShop;
using Microsoft.EntityFrameworkCore;

public class FloristContext : DbContext
{
    public DbSet<FlowerModel> Flowers { get; set; }

    public FloristContext(DbContextOptions<FloristContext> options) : base(options)
    {
        
    }
}