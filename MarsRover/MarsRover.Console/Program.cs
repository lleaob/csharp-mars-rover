namespace MarsRover.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Rover!");

            var instructions = new InputLayer.InstructionParser();
            var plateau = new InputLayer.PlateauParser();

            instructions.Instructions("lakujshgduqwipgerfahjbsdnasbjnaspqwieurpm");
            plateau.NewPlateau("30 15");

        }
    }
}
