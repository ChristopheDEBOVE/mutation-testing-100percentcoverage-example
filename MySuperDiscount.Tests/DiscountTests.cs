using FluentAssertions;
using MySuperDiscount;

namespace MutationTesting.Tests;

public class DiscountTests
{
    [Fact]
    public void ApplyDiscount_50Percent()
    {
        var price = Discount.ApplyDiscount(100, 50).Value;
        
        price.Should().Be(50); 
    }
    [Fact]
    public void ApplyDiscount_100Percent()
    {
        var price = Discount.ApplyDiscount(100, 100).Value;
        
        price.Should().Be(0); 
    }
    
    [Fact]
    public void ApplyDiscount_0Percent()
    {
        var price = Discount.ApplyDiscount(100, 0).Value;
        
        price.Should().Be(100); 
    }
    [Fact]
    public void ApplyDiscount_NegativeDiscount_ReturnsError()
    {
        var error = Discount.ApplyDiscount(100, -10).Error;
 
        error.Should().Be("Discount must be between 0 and 100.");
    }   
     

    [Fact]
    public void ApplyDiscount_DiscountOver100_ReturnsError()
    {
        var error = Discount.ApplyDiscount(100, 110).Error;
 
        error.Should().Be("Discount must be between 0 and 100.");
    }
}  