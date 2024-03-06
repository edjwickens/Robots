internal class Robot(Planet planet, Location landingLocation)
{
    public Planet Planet { get; } = planet;
    public Location Location { get; } = landingLocation;
    public bool IsLost { get; set; } = false;

    internal RobotEndState GetState()
    {
        return new RobotEndState(Location.X, Location.Y, Location.Orientation, IsLost);
    }

    internal void MoveForward()
    {
        switch (Location.Orientation)
        {
            case Orientation.North:
                Location.Y++;
                break;
            case Orientation.East:
                Location.X++;
                break;
            case Orientation.South:
                Location.Y--;
                break;
            case Orientation.West:
                Location.X--;
                break;
            default:
                break;
        }
    }

    internal void Rotate(RotationDirection rotationDirection)
    {
        int orientation = (int)Location.Orientation;
        if (rotationDirection == RotationDirection.Right)
            orientation++;

        if (rotationDirection == RotationDirection.Left)
            orientation--;

        // N.B: % is remainder, not modulo, hence adding 4 to avoid negatives
        Location.Orientation = (Orientation)((4 + orientation) % 4);
    }
}

internal class RobotEndState : Location
{
    public RobotEndState(int x, int y, Orientation orientation, bool isLost) : base(x, y, orientation)
    {
        IsLost = isLost;
    }

    public bool IsLost { get; }
}

enum RotationDirection
{
    Left, 
    Right
}