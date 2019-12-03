namespace MarsRoverChrisAnnor
{
    using System.Text;

    public class MarsRover
    {
        private readonly char[] _commands;
        private CommandProcessor commandProcessor;

        public readonly Coordinates _gridSize;
        public Rover _Rover { get; private set; }

        public MarsRover(string commands)
        {
            _commands = InputValidator.SetNavigationParameters(commands.ToUpper());
            _gridSize = new Coordinates { X = 25, Y = 25 };
            _Rover = new Rover(new RoverPosition { Direction = CardinalDirection.North });
        }



        public string Navigate()
        {
            commandProcessor = new CommandProcessor(_Rover, _commands, _gridSize);
            return commandProcessor.Navigate();
        }
    }
}