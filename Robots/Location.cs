
internal class Location(int x, int y, Orientation orientation)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public Orientation Orientation { get; set; } = orientation;
}

internal enum Orientation
{
    North = 0,
    East,
    South,
    West
}