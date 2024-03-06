
namespace Robots;

public class Planet
{
    public Planet(int xBound, int yBound)
    {
        if (xBound > 50 || yBound > 50)
            throw new ArgumentException("The maximum value for any coordinate is 50");

        XBound = xBound;
        YBound = yBound;
    }
    private readonly int XBound;
    private readonly int YBound;

    private readonly HashSet<KeyValuePair<int, int>> ScentCoordinates = [];

    internal void AddScent(Coordinates coordinates)
    {
        ScentCoordinates.Add(new KeyValuePair<int, int> (coordinates.X, coordinates.Y));
    }

    internal bool HasScent(Coordinates coordinates)
    {
        return ScentCoordinates.Contains(new KeyValuePair<int, int>(coordinates.X, coordinates.Y));
    }

    internal bool IsOutOfBounds(Coordinates coordinates)
    {
        if (coordinates.Y > YBound || coordinates.X > XBound
            || coordinates.Y < 0 || coordinates.X < 0)
            return true;
        return false;
    }

}