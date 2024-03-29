﻿using Robots;

internal class Robot(Planet planet, Location landingLocation)
{
    public Planet Planet { get; } = planet;
    public Location Location { get; set; } = landingLocation;
    public bool IsLost { get; set; } = false;

    internal RobotEndState GetState()
    {
        return new RobotEndState(Location.X, Location.Y, Location.Orientation, IsLost);
    }

    internal bool TryMoveForward()
    {
        if (IsLost)
            return false;

        var location = new Location(Location.X, Location.Y, Location.Orientation);

        switch (Location.Orientation)
        {
            case Orientation.North:
                location.Y++;
                break;
            case Orientation.East:
                location.X++;
                break;
            case Orientation.South:
                location.Y--;
                break;
            case Orientation.West:
                location.X--;
                break;
            default:
                break;
        }
        if (Planet.IsOutOfBounds(location))
        {
            IsLost = true;
            if(Planet.HasScent(location))
                IsLost = false;

            if (IsLost)
                Planet.AddScent(location);
        }
        else
            Location = location;

        return true;
    }

    internal void Rotate(RotationDirection rotationDirection)
    {
        if(IsLost)
            return;

        int orientation = (int)Location.Orientation;
        if (rotationDirection == RotationDirection.Right)
            orientation++;

        if (rotationDirection == RotationDirection.Left)
            orientation--;

        // N.B: % is remainder, not modulo, hence adding 4 to avoid negatives
        Location.Orientation = (Orientation)((4 + orientation) % 4);
    }
}

internal class RobotEndState(int x, int y, Orientation orientation, bool isLost) : Location(x, y, orientation)
{
    public bool IsLost { get; } = isLost;
}

enum RotationDirection
{
    Left, 
    Right
}