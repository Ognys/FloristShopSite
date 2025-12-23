using Microsoft.EntityFrameworkCore;

namespace FloristShop;

public class FlowerRopsitory(FlowerContext flowerContext)
{
    public async Task CreateFlowerData()
    {
        await flowerContext.Categorys.AddAsync(new Category
        {
            Name = "Цветы",
            Description = "Категоря для цвктов",
            Flowers = new List<Flower>
            {
                new Flower
                {
                    Name = "Розы",
                    Description = "Крачные розы"
                }
            }
        });

        await flowerContext.SaveChangesAsync();
    }

    public async Task<List<Flower>> GetAll()
    {
        return await flowerContext.Flowers.ToListAsync();
    }
}