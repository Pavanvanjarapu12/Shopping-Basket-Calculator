using System.Collections.Generic;

namespace ShoppingBasket.Interfaces;

public interface IBasketCalculator
{
    int CalculateTotal(IEnumerable<string> items);
}