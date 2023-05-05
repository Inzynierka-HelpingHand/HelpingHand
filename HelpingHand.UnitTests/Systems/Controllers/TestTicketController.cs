using FluentAssertions;
using HelpingHand.API.Controllers;
using HelpingHand.API.Models;
using Microsoft.Extensions.Logging;
using Moq;

namespace HelpingHand.UnitTests.Systems.Controllers
{
    public class UnitTest1
    {
        [Fact]
        public void GetTicketById_ReturnsTicket()
        {
            //Arrange
            var logger = new Mock<ILogger<TicketController>>();
            var controller = new TicketController(logger.Object);

            //Act
            var result = controller.GetTicketById(0);

            //Assert
            result.Should().BeOfType<Ticket>();
        }
    }
}