
namespace ShoppingBasket.Services;

public class OfferService
{
    // Buy 1 Get 1 Free
    public int CalculateMelonTotal(int quantity, int price)
    {
        int payableQuantity = (quantity + 1) / 2;

        return payableQuantity * price;
    }

    // Three for the price of two
    public int CalculateLimeTotal(int quantity, int price)
    {
        int payableQuantity = (quantity / 3) * 2
                              + quantity % 3;

        return payableQuantity * price;
    }
}
