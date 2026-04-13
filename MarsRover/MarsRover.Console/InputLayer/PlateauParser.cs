using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp.InputLayer
{
    public class PlateauParser
    {
        public int[] NewPlateau(string rawUserInput)
        {
            string[] strings = rawUserInput.Trim().Split(' ');
            int[] plateauSize = new int[2];
            try
            {
                if (strings.Length != 2)
                {
                    throw new Exception();
                }
                for (int i = 0; i < strings.Length; i++)
                {
                    plateauSize[i] = int.Parse(strings[i]);
                }

                Console.WriteLine($"Plateau Dimensions:\r\nX = {plateauSize[0]} : Y = {plateauSize[1]}");
                return plateauSize;
            }
            catch (Exception)
            {
                plateauSize = new int[] { 0, 0 };
                Console.WriteLine("Invalid plateau size. Please enter a valid number for X and Y.");
                return plateauSize;
            }
        }
    }
}
