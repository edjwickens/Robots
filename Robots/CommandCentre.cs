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
        return new Robot(planet,  landingLocation);
    }

    private RobotEndState NavigateRobot(Robot robot, List<Instruction> navigationInstructionSet)
    {
        foreach (var instruction in navigationInstructionSet)
        {
            switch (instruction)
            {
                case Instruction.Forward:
                    robot.MoveForward();
                    break;
                case Instruction.Left:
                    robot.Rotate(RotationDirection.Left);
                    break;
                case Instruction.Right:
                    robot.Rotate(RotationDirection.Right);
                    break;

            }

        }
        return robot.GetState();
    }

    private Location ParseLandingInstructions(string landingInstructions)
    {
        // TOOD: implement properly
        return new Location(1, 1, Orientation.East);
    }

    private List<Instruction> ParseNavigationInstructions(string navigationInstructions)
    {
        // TOOD: implement properly
        return new List<Instruction> { 
            Instruction.Right,
            Instruction.Forward,
            Instruction.Right,
            Instruction.Forward,
            Instruction.Right,
            Instruction.Forward,
            Instruction.Right,
            Instruction.Forward,
            Instruction.Right,

        };
    }

    private string SerializeOutPut(RobotEndState robotEndState)
    {
        //TODO: add whether lost
        return $"{robotEndState.X} {robotEndState.Y} {robotEndState.Orientation.ToString()[0]}";
    }
}

enum Instruction
{
    Left,
    Right,
    Forward
}