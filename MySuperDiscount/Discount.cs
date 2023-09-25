using CSharpFunctionalExtensions;

namespace MySuperDiscount;

public static class Discount
{
    public static Result<decimal> ApplyDiscount(decimal originalAmount, decimal discountPercentage)
    {
        if (discountPercentage < 0 || discountPercentage > 100)
            return Result.Failure<decimal>("Discount must be between 0 and 100.");

        var discountedAmount = originalAmount * (1 - (discountPercentage / 100));
        return discountedAmount;
    }
}