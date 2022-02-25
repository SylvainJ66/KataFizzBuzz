using KataFizzBuzzService;
using Xunit;

namespace KataFizzBuzzService_Tests;

public class FizzBuzzService_Tests
{
    [Fact]
    public void DoNothing()
    {
        Assert.False(false);
    }

    [Fact]
    public void Given1ShouldReturn1()
    {
        Assert.Equal("1", new FizzBuzzService().MakeLine(1));
    }

    [Fact]
    public void Given2ShouldReturn2()
    {
        Assert.Equal("2", new FizzBuzzService().MakeLine(2));
    }
    
    [Fact]
    public void Given3ShouldReturnFizz()
    {
        Assert.Equal("Fizz", new FizzBuzzService().MakeLine(3));
    }

    [Fact]
    public void Given6ShouldReturnFizz()
    {
        Assert.Equal("Fizz", new FizzBuzzService().MakeLine(6));
    }

    [Fact]
    public void Given5ShouldReturnBuzz()
    {
        Assert.Equal("Buzz", new FizzBuzzService().MakeLine(5));
    }

    [Fact]
    public void Given10ShouldReturnBuzz()
    {
        Assert.Equal("Buzz", new FizzBuzzService().MakeLine(10));
    }

    [Fact]
    public void Given15ShouldReturnFizzBuzz()
    {
        Assert.Equal("FizzBuzz", new FizzBuzzService().MakeLine(15));
    }

    [Fact]
    public void Given30ShouldReturnFizzBuzz()
    {
        Assert.Equal("FizzBuzz", new FizzBuzzService().MakeLine(30));
    }

    [Fact]
    public void RunShouldContains()
    {
        Assert.Contains(@"12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz1617Fizz19Buzz", new FizzBuzzService().Run());
    }
}
