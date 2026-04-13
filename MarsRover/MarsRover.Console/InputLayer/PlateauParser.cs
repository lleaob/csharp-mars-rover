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
        public PlateauSize NewPlateau(string rawUserInput)
        {
            string[] strings = rawUserInput.Trim().Split(' ');

            try
            {
                if (strings.Length != 2)
                {
                    throw new Exception();
                }
                
                int xSize = int.Parse(strings[0]);
                int ySize = int.Parse(strings[1]);

                var newPlateu = new PlateauSize(xSize, ySize);
                Console.WriteLine(newPlateu);
                return newPlateu;

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid plateau size. Please enter a valid number for X and Y.");
                return new PlateauSize(0, 0);
            }
        }
    }
}
