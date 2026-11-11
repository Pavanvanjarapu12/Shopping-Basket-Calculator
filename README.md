# Shopping Basket Calculator

A C# console application that calculates the total cost of a shopping basket using product prices and special promotional offers.

## Features

- Calculates the total cost of multiple products.
- Supports product pricing in pence.
- Applies Buy One Get One Free offer on Melons.
- Applies Three for the Price of Two offer on Limes.
- Validates product names and handles invalid input.
- Includes unit tests using xUnit.

## Product Pricing

| Product | Price |
| ------- | ----: |
| Apple   |   35p |
| Banana  |   20p |
| Melon   |   50p |
| Lime    |   15p |

## Special Offers

- **Melon:** Buy One Get One Free. For every two melons, only one is charged.
- **Lime:** Three for the Price of Two. For every three limes, only two are charged.

## Example

**Input:**

```text
Apple, Apple, Banana, Melon, Melon, Lime, Lime, Lime
```

**Calculation:**

| Product         | Quantity |    Total |
| --------------- | -------: | -------: |
| Apple           |        2 |      70p |
| Banana          |        1 |      20p |
| Melon           |        2 |      50p |
| Lime            |        3 |      30p |
| **Grand Total** |          | **170p** |

## Technologies Used

- C#
- .NET 10
- xUnit for unit testing

## Project Structure

```text
DeltaCapitaAssessment/
│
├── ShoppingBasket/
│   ├── Interfaces/
│   │   └── IBasketCalculator.cs
│   ├── Models/
│   │   └── Product.cs
│   ├── Services/
│   │   ├── BasketCalculator.cs
│   │   ├── PricingService.cs
│   │   └── OfferService.cs
│   └── Program.cs
│
├── ShoppingBasket.Tests/
│   ├── UnitTest1.cs
│   └── OfferServiceTests.cs
│
└── ShoppingBasket.slnx
```

## How to Run

1. Install the .NET 10 SDK.
2. Clone this repository.
3. Open a terminal in the solution folder.
4. Build the project:

```bash
dotnet build
```

5. Run the application:

```bash
dotnet run --project ShoppingBasket
```

## Run Unit Tests

Execute the following command from the solution folder:

```bash
dotnet test
```

The project currently has **31 passing unit tests**.

## Author

Pavan Kumar Vanjarapu
