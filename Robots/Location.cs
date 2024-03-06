// See https://aka.ms/new-console-template for more information


internal class Location(int x, int y, Orientation orientation)
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public Orientation Orientation { get; } = orientation;
}

internal enum Orientation
{
    North = 0,
    East,
    South,
    West
}