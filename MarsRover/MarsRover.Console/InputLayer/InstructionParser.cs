using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp.InputLayer
{
    public class InstructionParser
    {
        public List<Instruction> Instructions(string rawUserInput)
        {
            var instructions = new List<Instruction>();

            // Normalizes user input
            char[] letters = rawUserInput.Trim().ToUpper().ToCharArray();

            // Parses input into Instruction list
            foreach (char letter in letters)
            {
                switch (letter)
                {
                    case 'L':
                        instructions.Add(Instruction.L);
                        break;
                    case 'R':
                        instructions.Add(Instruction.R);
                        break;
                    case 'M':
                        instructions.Add(Instruction.M);
                        break;
                    default:
                        Console.WriteLine($"Skipping instruction {letter}. Only L, R or M are allowed.");
                        break;
                }
            }

            // Prints result to user
            string resultingInstructions = String.Empty;
            foreach (Instruction instruction in instructions)
            {
                resultingInstructions += instruction;
            }
            if (resultingInstructions.Length > 0) 
            {
                Console.WriteLine($"Final instructions: {resultingInstructions}.");
            } 
            else
            {
                Console.WriteLine("Final instructions: None.");
            }

            return instructions;
        }
    }
}
