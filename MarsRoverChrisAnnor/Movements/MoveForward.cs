namespace MarsRoverChrisAnnor
{
    using System;
    using System.Collections.Generic;

    public static class MoveForward
    {
        public delegate Coordinates MoveRoverForward(Coordinates currentDirection, int numberOfMoves);

        public static Dictionary<CardinalDirection, MoveRoverForward> MoveFunctions =
            new Dictionary<CardinalDirection, MoveRoverForward>
                {
                    {CardinalDirection.North, MoveNorth},
                    {CardinalDirection.East, MoveEast},
                    {CardinalDirection.South, MoveSouth},
                    {CardinalDirection.West, MoveWest}
                };

        public static Coordinates Move(int command, RoverPosition currentPosition)
        {
            return MoveFunctions[currentPosition.Direction](currentPosition.Coordinates, Convert.ToInt32(command));
        }

        private static Coordinates MoveEast(Coordinates coordinates, int numberOfMoves)
        {
            return new Coordinates()
                       {
                           X = coordinates.X + numberOfMoves,
                           Y = coordinates.Y
                       };
        }

        private static Coordinates MoveSouth(Coordinates coordinates, int numberOfMoves)
        {
            return new Coordinates()
                       {
                           X = coordinates.X,
                           Y = coordinates.Y - numberOfMoves
                       };
        }

        private static Coordinates MoveWest(Coordinates coordinates, int numberOfMoves)
        {
            return new Coordinates()
                       {
                           X = coordinates.X - numberOfMoves,
                           Y = coordinates.Y
                       };
        }

        private static Coordinates MoveNorth(Coordinates coordinates, int numberOfMoves)
        {
            return new Coordinates()
                       {
                           X = coordinates.X,
                           Y = coordinates.Y + numberOfMoves
                       };
        }
    }
}