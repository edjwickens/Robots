
public class Planet(int xBound, int yBound)
{
    private int XBound = xBound;
    private int YBound = yBound;

    internal bool IsOutOfBounds(Location location)
    {
        if(location.Y > YBound || location.X > XBound 
            || location.Y < 0 || location.X < 0) 
            return true;
        return false;
    }
}