
using ShoppingBasket.Services;
using ShoppingBasket.Interfaces;
using System;
using System.Collections.Generic;

List<string> basket = new List<string>
{
    "Apple",
    "Apple",
    "Banana",
    "Melon",
    "Melon",
    "Lime",
    "Lime",
    "Lime"
};

PricingService pricingService = new PricingService();
OfferService offerService = new OfferService();

IBasketCalculator calculator = new BasketCalculator(pricingService, offerService);

int total = calculator.CalculateTotal(basket);

Console.WriteLine("===== Shopping Basket =====");

foreach (string item in basket)
{
    Console.WriteLine(item);
}

Console.WriteLine("===========================");
Console.WriteLine($"Total Cost: {total}p");
