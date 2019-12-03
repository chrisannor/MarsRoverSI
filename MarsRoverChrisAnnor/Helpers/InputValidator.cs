namespace MarsRoverChrisAnnor
{
    using System;
    using System.Linq;

    public static class InputValidator
    {
        
        private static readonly char[] ValidCommands = {'L', 'R'};

        private static char[] _validatedCommand;
        
        public static char[] SetNavigationParameters(string command)
        {
            ValidateCommand(command);

            return _validatedCommand;
        }


        private static void ValidateCommand(string command)
        {
            _validatedCommand = new char[command.Length];

            for (var index = 0; index < command.Length; index++)
            {
                var c = command[index];
                if (ValidCommands.Contains(c) || char.IsDigit(c)) _validatedCommand[index] = c;
                else throw  new ArgumentOutOfRangeException(nameof(command), "The command contains one or more invalid strings");
            }
        }


    }
}