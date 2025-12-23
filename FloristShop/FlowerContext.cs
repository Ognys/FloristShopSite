using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FloristShop;

public class FlowerContext(DbContextOptions<FlowerContext> options) : DbContext(options)
{
    public DbSet<Flower> Flowers { get; set; }
    public DbSet<Category> Categorys { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new FlowerConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany(x => x.Flowers)
        .WithOne(x => x.Category)
        .HasForeignKey(x => x.CategoryId);
    }
}

public class FlowerConfiguration : IEntityTypeConfiguration<Flower>
{
    public void Configure(EntityTypeBuilder<Flower> builder)
    {
        builder.HasKey(x => x.Id);
    }
}