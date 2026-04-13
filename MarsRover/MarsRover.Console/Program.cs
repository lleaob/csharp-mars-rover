namespace MarsRover.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Rover!");

            var plateau = new InputLayer.PlateauParser();
            var rover = new InputLayer.RoverPositionParser();
            var instructions = new InputLayer.InstructionParser();

            foreach (var arg in args)
            {
                Console.WriteLine($"cmdline input: {arg}");
            }
            plateau.NewPlateau($"{args[0]} {args[1]}");
            rover.NewRover($"{args[2]} {args[3]} {args[4]}");
            instructions.Instructions(args[5]);

        }
    }
}
