namespace FloristShop;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Flower> Flowers { get; set; }
}