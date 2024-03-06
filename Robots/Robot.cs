// See https://aka.ms/new-console-template for more information


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
        throw new NotImplementedException();
    }

    internal void Rotate(RotationDirection left)
    {
        throw new NotImplementedException();
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