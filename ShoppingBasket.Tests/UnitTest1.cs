
using Xunit;
using ShoppingBasket.Services;
using System;

namespace ShoppingBasket.Tests;

public class BasketCalculatorTests
{
    private readonly BasketCalculator calculator = new BasketCalculator(
        new PricingService(),
        new OfferService()
    );

    [Theory]
    [InlineData(new string[] { }, 0)]
    [InlineData(new string[] { "Apple" }, 35)]
    [InlineData(new string[] { "Banana" }, 20)]
    [InlineData(new string[] { "Melon" }, 50)]
    [InlineData(new string[] { "Lime" }, 15)]
    [InlineData(new string[] { "Apple", "Apple" }, 70)]
    [InlineData(new string[] { "Melon", "Melon" }, 50)]
    [InlineData(new string[] { "Melon", "Melon", "Melon" }, 100)]
    [InlineData(new string[] { "Lime", "Lime", "Lime" }, 30)]
    [InlineData(new string[] { "Lime", "Lime", "Lime", "Lime" }, 45)]
    [InlineData(new string[] { "Apple", "Banana" }, 55)]
    [InlineData(new string[] { "Apple", "Apple", "Banana", "Melon", "Melon", "Lime", "Lime", "Lime" }, 170)]
    public void CalculateTotal_ReturnsExpectedPrice(
        string[] basket, int expectedTotal)
    {
        int actualTotal = calculator.CalculateTotal(basket);

        Assert.Equal(expectedTotal, actualTotal);
    }

    [Fact]
    public void CalculateTotal_InvalidProduct_ThrowsException()
    {
        string[] basket = { "Apple", "Orange" };

        Assert.Throws<ArgumentException>(
            () => calculator.CalculateTotal(basket));
    }

    [Fact]
    public void CalculateTotal_NullBasket_ThrowsException()
    {
        Assert.Throws<ArgumentNullException>(
            () => calculator.CalculateTotal(null!));
    }

    [Fact]
    public void CalculateTotal_IgnoresCaseAndSpaces()
    {
        string[] basket = { " apple ", "BANANA" };

        int result = calculator.CalculateTotal(basket);

        Assert.Equal(55, result);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void CalculateTotal_EmptyProduct_ThrowsException(string item)
    {
        string[] basket = { item };

        Assert.Throws<ArgumentException>(
            () => calculator.CalculateTotal(basket));
    }

    [Fact]
    public void CalculateTotal_NullItem_ThrowsException()
    {
        string[] basket = { null! };

        Assert.Throws<ArgumentException>(
            () => calculator.CalculateTotal(basket));
    }
}

