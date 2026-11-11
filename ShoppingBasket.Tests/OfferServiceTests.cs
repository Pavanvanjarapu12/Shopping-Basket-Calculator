
using Xunit;
using ShoppingBasket.Services;

namespace ShoppingBasket.Tests;

public class OfferServiceTests
{
    private readonly OfferService _offerService = new();

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 50)]
    [InlineData(2, 50)]
    [InlineData(3, 100)]
    [InlineData(4, 100)]
    [InlineData(5, 150)]
    public void CalculateMelonTotal_ReturnsExpectedPrice(
        int quantity, int expected)
    {
        int result = _offerService.CalculateMelonTotal(quantity, 50);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 15)]
    [InlineData(2, 30)]
    [InlineData(3, 30)]
    [InlineData(4, 45)]
    [InlineData(5, 60)]
    [InlineData(6, 60)]
    public void CalculateLimeTotal_ReturnsExpectedPrice(
        int quantity, int expected)
    {
        int result = _offerService.CalculateLimeTotal(quantity, 15);

        Assert.Equal(expected, result);
    }
}
