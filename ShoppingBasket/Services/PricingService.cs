
using System;
using ShoppingBasket.Models;

namespace ShoppingBasket.Services;

public class PricingService
{
    public Product GetProduct(string productName)
    {
        if (string.IsNullOrWhiteSpace(productName))
        {
            throw new ArgumentException("Product name cannot be empty.");
        }

        return productName.Trim().ToLowerInvariant() switch
        {
            "apple" => new Product("Apple", 35),
            "banana" => new Product("Banana", 20),
            "melon" => new Product("Melon", 50),
            "lime" => new Product("Lime", 15),

            _ => throw new ArgumentException(
                $"Invalid product: {productName}")
        };
    }
}
