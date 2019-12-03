namespace MarsRoverChrisAnnor
{
    using System;

    public class Rover
    {
        public RoverPosition CurrentPosition;

        public Rover()
        {
            CurrentPosition = new RoverPosition(){Direction = CardinalDirection.North};
        }

        public Rover(RoverPosition startingPosition)
        {
            CurrentPosition = startingPosition;
        }

        public void UpdateCurrentDirection(CardinalDirection newDirection)
        {
            CurrentPosition.Direction = newDirection;
        }

        public void UpdateCurrentCoordinates(Coordinates newCoordinates)
        {
            CurrentPosition.Coordinates = newCoordinates;
            Console.WriteLine(GetCurrentLocation());
        }

        public string GetCurrentLocation()
        {
            return $"{CurrentPosition.Coordinates.X},{CurrentPosition.Coordinates.Y} Facing: {CurrentPosition.Direction}";
        }
    }
}