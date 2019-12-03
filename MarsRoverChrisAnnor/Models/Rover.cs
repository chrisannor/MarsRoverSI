namespace MarsRoverChrisAnnor
{
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
        }
    }
}