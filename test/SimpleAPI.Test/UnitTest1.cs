using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsForecastsById()
        {
            var returnValue = controller.GetById(1);
            Assert.Equal("Rost Name", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
