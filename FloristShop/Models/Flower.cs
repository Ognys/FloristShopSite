namespace FloristShop;

public class Flower
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public Guid CategoryId { get; set; }
}