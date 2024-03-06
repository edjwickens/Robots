// See https://aka.ms/new-console-template for more information


public class CommandCentre(Planet planet)
{
    private readonly Planet Planet = planet;

    public string ExecuteInstructions(string landingInstructions, string navigationInstructions)
    {
        var landingLocation = ParseLandingInstructions(landingInstructions);
        Robot robot = LandRobot(Planet, landingLocation);
        var navigationInstructionSet = ParseNavigationInstructions(navigationInstructions);
        var robotEndState = NavigateRobot(robot, navigationInstructionSet);
        return SerializeOutPut(robotEndState);
    }
    private Robot LandRobot(Planet planet, Location landingLocation)
    {
        throw new NotImplementedException();
    }

    private RobotEndState NavigateRobot(Robot robot, List<Instruction> navigationInstructions)
    {
        throw new NotImplementedException();
    }

    private Location ParseLandingInstructions(string landingInstructions)
    {
        throw new NotImplementedException();
    }

    private List<Instruction> ParseNavigationInstructions(string navigationInstructions)
    {
        throw new NotImplementedException();
    }

    private string SerializeOutPut(RobotEndState robotEndState)
    {
        throw new NotImplementedException();
    }
}

enum Instruction
{
    Left,
    Right,
    Forward
}