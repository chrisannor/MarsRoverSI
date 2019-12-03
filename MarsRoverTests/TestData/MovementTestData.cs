namespace MarsRoverTests
{
    using System.Collections;
    using System.Collections.Generic;

    using MarsRoverChrisAnnor;

    public class MovementTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new RoverPosition { Coordinates = new Coordinates { X = 0, Y = 0 },Direction = CardinalDirection.North}, 1, new Coordinates { X = 0, Y = 1 } };yield return new object[] { new RoverPosition { Coordinates = new Coordinates { X = 0, Y = 0 },Direction = CardinalDirection.North}, 1, new Coordinates { X = 0, Y = 1 } };
            yield return new object[] { new RoverPosition { Coordinates = new Coordinates { X = 0, Y = 0 }, Direction = CardinalDirection.East }, 1, new Coordinates { X = 1, Y = 0 } };
            yield return new object[] { new RoverPosition { Coordinates = new Coordinates { X = 1, Y = 1 }, Direction = CardinalDirection.South }, 1, new Coordinates { X = 1, Y = 0 } };
            yield return new object[] { new RoverPosition { Coordinates = new Coordinates { X = 1, Y = 1 }, Direction = CardinalDirection.West }, 1, new Coordinates { X = 0, Y = 1 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}