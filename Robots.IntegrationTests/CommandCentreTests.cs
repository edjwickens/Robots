using FluentAssertions;

namespace Robots.IntegrationTests;

public class CommandCentreTests
{
    [Fact]
    public void GivenInBoundsInstructions_WhenExecuted_ThenCorrectEndStateReturned()
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

    [Fact]
    public void GivenOutOfBoundsInstructions_WhenExecuted_ThenLostEndStateReturned()
    {
        // Arrange
        var mars = new Planet(5, 3);
        var landingInstructions = "3 2 N";
        var navigationInstructions = "FRRFLLFFRRFLL";
        var expectedEndState = "3 3 N LOST";

        var commandCentre = new CommandCentre(mars);

        // Act
        string endState = commandCentre.ExecuteInstructions(landingInstructions, navigationInstructions);

        // Assert
        endState.Should().Be(expectedEndState);
    }

    [Fact]
    public void GivenOutOfBoundsInstructions_AndPreviouslyLostRobot_WhenExecuted_ThenCorrectEndStateReturned()
    {
        // Arrange
        var mars = new Planet(5, 3);
        var landingInstructions = "0 3 W";
        var navigationInstructions = "LLFFFLFLFL";
        var expectedEndState = "2 3 S";

        var commandCentre = new CommandCentre(mars);
        // previously lost robot
        commandCentre.ExecuteInstructions("3 2 N", "FRRFLLFFRRFLL");

        // Act
        string endState = commandCentre.ExecuteInstructions(landingInstructions, navigationInstructions);

        // Assert
        endState.Should().Be(expectedEndState);
    }

}