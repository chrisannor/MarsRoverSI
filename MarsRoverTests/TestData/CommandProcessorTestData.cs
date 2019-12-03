namespace MarsRoverTests
{
    using System.Collections;
    using System.Collections.Generic;

    using MarsRoverChrisAnnor;

    public class CommandProcessorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Rover(), new [] {'1','R','5','L','4'}, new Coordinates{X=5,Y=5}  };

        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}