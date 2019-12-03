namespace MarsRoverChrisAnnor
{
    using System;
    using System.Collections.Generic;

    public class ChangeDirection
    {
        public delegate CardinalDirection ChangeRoverDirection(CardinalDirection direction);

        static readonly LinkedList<CardinalDirection> directions =
            new LinkedList<CardinalDirection>(new[] { CardinalDirection.North, CardinalDirection.East, CardinalDirection.South, CardinalDirection.West });

        public static readonly Dictionary<char, ChangeRoverDirection> DirectionFunctions =
            new Dictionary<char, ChangeRoverDirection>
                {
                    {'L', TurnLeft},
                    {'R', TurnRight}
                };

        public static CardinalDirection GetNextDirection(CardinalDirection currentDirection, char stepCommand)
        {
            return DirectionFunctions[stepCommand](currentDirection);
        }

        private static CardinalDirection TurnRight(CardinalDirection currentDirection)
        {
            LinkedListNode<CardinalDirection> currentIndex = directions.Find(currentDirection);
            return currentIndex.NextOrFirst().Value;
        }

        private static CardinalDirection TurnLeft(CardinalDirection currentDirection)
        {
            LinkedListNode<CardinalDirection> currentIndex = directions.Find(currentDirection);
            return currentIndex.PreviousOrLast().Value;
        }

    }
}