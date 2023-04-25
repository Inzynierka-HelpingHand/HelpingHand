using FluentAssertions;
using HelpingHand.API;
using HelpingHand.API.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace HelpingHand.UnitTests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			//Arrange
			var logger = new Mock<ILogger<WeatherForecastController>>();
			var controller = new WeatherForecastController(logger.Object);

			//Act
			var result = controller.Get();

			//Assert
			result.Should().BeOfType<WeatherForecast[]>();
		}
		[Fact]
		public void Test2()
		{
			//Arrange
			var logger = new Mock<ILogger<WeatherForecastController>>();
			var controller = new WeatherForecastController(logger.Object);

			//Act
			var result = controller.GetById(0);

			//Assert
			result.Should().BeOfType<WeatherForecast[]>();
		}
	}
}