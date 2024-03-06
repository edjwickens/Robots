
internal class Location(int x, int y, Orientation orientation): Coordinates(x, y)
{
    public Orientation Orientation { get; set; } = orientation;
}

internal class Coordinates(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
}

internal enum Orientation
{
    North = 0,
    East,
    South,
    West
}