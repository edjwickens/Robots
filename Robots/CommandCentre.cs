using System.ComponentModel;

public class CommandCentre(Planet planet)
{
    private readonly Planet Planet = planet;

    public string ExecuteInstructions(string landingInstructions, string navigationInstructions)
    {
        var landingLocation = ParseLandingInstructions(landingInstructions);
        Robot robot = LandRobot(Planet, landingLocation);
        var navigationInstructionSet = ParseNavigationInstructions(navigationInstructions);
        var robotEndState = NavigateRobot(robot, navigationInstructionSet);
        return SerializeOutput(robotEndState);
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
        var landingInstructionParts = landingInstructions.Split(null);
        var x = int.Parse(landingInstructionParts[0]);
        var y = int.Parse(landingInstructionParts[1]);
        var orientation = landingInstructionParts[2] switch
        {
            "N" => Orientation.North,
            "E" => Orientation.East,
            "S" => Orientation.South,
            "W" => Orientation.West,
            _ => throw new InvalidEnumArgumentException(
                $"Invalid orientation string: {landingInstructionParts[2]}"),
        };

        return new Location(x, y, orientation);
    }

    private List<Instruction> ParseNavigationInstructions(string navigationInstructions)
    {
        List<Instruction> instructionsList = [];

        foreach (char instructionChar in navigationInstructions)
        {
            switch (instructionChar)
            {
                case 'L':
                    instructionsList.Add(Instruction.Left);
                    break;
                case 'R':
                    instructionsList.Add(Instruction.Right);
                    break;
                case 'F':
                    instructionsList.Add(Instruction.Forward);
                    break;
                default:
                    throw new ArgumentException($"Invalid instruction character: {instructionChar}");
            }
        }

        return instructionsList;
    }

    private string SerializeOutput(RobotEndState robotEndState)
    {
        var lostSuffix = robotEndState.IsLost ? "LOST" : "";
        return $"{robotEndState.X} {robotEndState.Y} {robotEndState.Orientation.ToString()[0]}"
            + lostSuffix;
    }
}

enum Instruction
{
    Left,
    Right,
    Forward
}