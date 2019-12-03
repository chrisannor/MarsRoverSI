namespace MarsRoverChrisAnnor
{
    using System;

    public class CommandProcessor
    {
        private readonly Rover _rover;
        private readonly char[] _commands;

        private readonly Coordinates _gridSize;

        public CommandProcessor(Rover rover, char[] commands, Coordinates gridSize)
        {
            _rover = rover;
            _commands = commands;
            _gridSize = gridSize;
        }

        public string Navigate()
        {

            foreach (var step in _commands)
            {
                try
                {
                    MoveRobot(step);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            var result = $"{_rover.CurrentPosition.Coordinates.X} {_rover.CurrentPosition.Coordinates.Y} {_rover.CurrentPosition.Direction}";

            return result;
        }

        private void MoveRobot(char stepCommand)
        {
            int forwardMoves;
            if (int.TryParse(stepCommand.ToString(), out forwardMoves))
            {
                var newCoordinates = MoveForward.Move(forwardMoves, _rover.CurrentPosition);

                if (newCoordinates.X > _gridSize.X || newCoordinates.Y > _gridSize.Y)
                {
                    throw new ArgumentOutOfRangeException(nameof(stepCommand), "Command takes robot off the grid");
                }

                _rover.UpdateCurrentCoordinates(newCoordinates);
            }
            else
            {
                var newDirection = ChangeDirection.GetNextDirection(_rover.CurrentPosition.Direction, stepCommand);

                _rover.UpdateCurrentDirection(newDirection);
            }
        }
    }
}