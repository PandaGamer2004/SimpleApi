using System.Linq;
using WebApplication4.Controllers;
using Xunit;

namespace UnitTests;

public class WeatherForecastTests
{
    [Fact]
    public void GET_RETURNS_FIVE_ITEMS()
    {
        
        //Init
        WeatherForecastController forecastController = new(null!);

        //When
        var forecastItems = forecastController.Get();

        //THEN
        Assert.Equal(5, forecastItems.Count());

    }   
}