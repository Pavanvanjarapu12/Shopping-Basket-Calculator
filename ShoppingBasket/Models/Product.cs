
namespace ShoppingBasket.Models;

public class Product
{
    public string Name { get; set; }
    public int PriceInPence { get; set; }

    public Product(string name, int priceInPence)
    {
        Name = name;
        PriceInPence = priceInPence;
    }
}
