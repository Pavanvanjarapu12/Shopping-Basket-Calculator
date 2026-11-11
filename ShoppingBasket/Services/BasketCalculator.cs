
using ShoppingBasket.Interfaces;
using System;
using System.Collections.Generic;

namespace ShoppingBasket.Services;

public class BasketCalculator : IBasketCalculator
{
    private readonly PricingService _pricingService;
    private readonly OfferService _offerService;

    public BasketCalculator(
        PricingService pricingService,
        OfferService offerService)
    {
        _pricingService = pricingService;
        _offerService = offerService;
    }

    public int CalculateTotal(IEnumerable<string> items)
    {
        if (items == null)
        {
            throw new ArgumentNullException(nameof(items));
        }

        int appleCount = 0;
        int bananaCount = 0;
        int melonCount = 0;
        int limeCount = 0;

        foreach (string item in items)
        {
            var product = _pricingService.GetProduct(item);

            switch (product.Name)
            {
                case "Apple":
                    appleCount++;
                    break;
                case "Banana":
                    bananaCount++;
                    break;
                case "Melon":
                    melonCount++;
                    break;
                case "Lime":
                    limeCount++;
                    break;
            }
        }

        int total = 0;

        total += appleCount * _pricingService.GetProduct("Apple").PriceInPence;
        total += bananaCount * _pricingService.GetProduct("Banana").PriceInPence;

        total += _offerService.CalculateMelonTotal(
            melonCount, _pricingService.GetProduct("Melon").PriceInPence);

        total += _offerService.CalculateLimeTotal(
            limeCount, _pricingService.GetProduct("Lime").PriceInPence);

        return total;
    }
}
