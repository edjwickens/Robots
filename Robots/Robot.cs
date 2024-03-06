// See https://aka.ms/new-console-template for more information

internal class Robot
{
}

internal class RobotEndState : Location
{
    public RobotEndState(int x, int y, Orientation orientation, bool isLost) : base(x, y, orientation)
    {
        IsLost = isLost;
    }

    public bool IsLost { get; }
}