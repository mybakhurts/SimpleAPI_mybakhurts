using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecast controller = new WeatherForecast();
    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = WeatherForecast.get();
        Assert.Equal("Les Jackson", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}