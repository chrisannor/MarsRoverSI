using System;

namespace MarsRoverChrisAnnor
{
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mars Rover console app...");
            Console.WriteLine("Please enter a valid rover command using a combination of 'L','R' and digits 1-9");
            StringBuilder finalPosition = new StringBuilder();
            var isSuccessful = false;
            while (!isSuccessful)
            {
                var command = Console.ReadLine();
                try
                {
                    var MarsRover = new MarsRover(command);
                    finalPosition.Append(MarsRover.Navigate());
                    isSuccessful = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"An error occured: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something bad happened...");
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Final position {finalPosition}");
            Console.WriteLine("Mission complete!");
            Console.ReadLine();
        }
    }
}
