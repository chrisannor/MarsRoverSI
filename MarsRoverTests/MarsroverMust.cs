using System;
using Xunit;

namespace MarsRoverTests
{
    using MarsRoverChrisAnnor;

    public class MarsRoverMust
    {
        [Theory]
        [InlineData(CardinalDirection.North, 'R', CardinalDirection.East)]
        [InlineData(CardinalDirection.East, 'R', CardinalDirection.South)]
        [InlineData(CardinalDirection.South, 'R', CardinalDirection.West)]
        [InlineData(CardinalDirection.West, 'R', CardinalDirection.North)]
        [InlineData(CardinalDirection.North, 'L', CardinalDirection.West)]
        [InlineData(CardinalDirection.East, 'L', CardinalDirection.North)]
        [InlineData(CardinalDirection.South, 'L', CardinalDirection.East)]
        [InlineData(CardinalDirection.West, 'L', CardinalDirection.South)]
        public void Turn_in_the_right_direction_when_direction_command_given(CardinalDirection startingDirection, char command, CardinalDirection result)
        {
            Assert.Equal(result, ChangeDirection.GetNextDirection(startingDirection, command));
        }

        [Theory]
        [ClassData(typeof(MovementTestData))]
        public void Move_in_the_right_direction_when_command_is_given(RoverPosition startPosition, int command, Coordinates result)
        {
            Assert.Equal(result, MoveForward.Move(command,startPosition));
        }

        [Theory]
        [ClassData(typeof(CommandProcessorTestData))]
        public void Remain_on_grid_given_valid_commands_for_appropriate_grid(Rover rover, char[] commands, Coordinates gridSize)
        {
            TestHelper.DoesNotThrows<ArgumentOutOfRangeException>(() => new CommandProcessor(rover,commands,gridSize));
        }

        [Fact]
        public void Return_throw_invalid_exception_when_invalid_input_is_entered()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarsRover("Invalid_input"));
        }
    }
}
