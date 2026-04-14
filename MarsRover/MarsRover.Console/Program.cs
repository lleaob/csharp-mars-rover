using MarsRover.ConsoleApp.InputLayer;
using MarsRover.ConsoleApp.LogicLayer;
using MarsRover.ConsoleApp.Models;

namespace MarsRover.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Rover!");

            List<string> input = new List<string>()
            {
                "5 5",
                "1 2 N",
                "LMLMLMLMM",
                "3 3 E",
                "MMRMMRMRRM"
            };

            // Initializing parsers
            PlateauParser plateauParser = new();
            RoverPositionParser roverParser = new();
            InstructionParser instructionParser = new();
            // Parsing
            PlateauSize parsedPlateau = plateauParser.NewPlateau(input[0]);
            RoverPosition parsedRover1 = roverParser.NewRover(input[1]);
            List<Instruction> rover1Instructions = instructionParser.Instructions(input[2]);
            RoverPosition parsedRover2 = roverParser.NewRover(input[3]);
            List<Instruction> rover2Instructions = instructionParser.Instructions(input[4]);
            // Object creation
            Plateau plateau = new(parsedPlateau.XBoundary, parsedPlateau.YBoundary);
            Rover rover1 = new(parsedRover1.X, parsedRover1.Y, parsedRover1.Facing);
            Rover rover2 = new(parsedRover2.X, parsedRover2.Y, parsedRover2.Facing);

            // Perform actions
            foreach (Instruction instruction in rover1Instructions)
            {
                if (instruction != Instruction.M)
                {
                    rover1.Rotate(instruction);
                } else
                {
                    rover1.Move(plateau);
                }
            }

            foreach (Instruction instruction in rover2Instructions)
            {
                if (instruction != Instruction.M)
                {
                    rover2.Rotate(instruction);
                }
                else
                {
                    rover2.Move(plateau);
                }
            }

            Console.WriteLine($"Plateau:\nX = {plateau.X} : Y = {plateau.Y}\n" +
                $"Final Rover 1:\nX = {rover1.X} : Y = {rover1.Y} : Direction = {rover1.Facing}\n" +
                $"Final Rover 2:\nX = {rover2.X} : Y = {rover2.Y} : Direction = {rover2.Facing}\n");
        }
    }
}
