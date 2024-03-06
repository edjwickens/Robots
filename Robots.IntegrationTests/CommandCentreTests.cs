using FluentAssertions;

namespace Robots.IntegrationTests;

public class CommandCentreTests
{
    [Fact]
    public void ExecuteInstructions_Should_Return_Correct_EndState()
    {
        // Arrange
        var mars = new Planet(5, 3);
        var landingInstructions = "1 1 E";
        var navigationInstructions = "RFRFRFRF";
        var expectedEndState = "1 1 E";

        var commandCentre = new CommandCentre(mars);

        // Act
        string endState = commandCentre.ExecuteInstructions(landingInstructions, navigationInstructions);

        // Assert
        endState.Should().Be(expectedEndState);
    }
}