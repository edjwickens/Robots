
namespace Robots;

public class Planet(int xBound, int yBound)
{
    private readonly int XBound = xBound;
    private readonly int YBound = yBound;

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