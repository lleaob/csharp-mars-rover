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
            if (string.IsNullOrEmpty(rawUserInput))
            {
                return new PlateauSize(0, 0);
            }

            rawUserInput = rawUserInput.Trim();

            int xSize = int.Parse(rawUserInput.Split(' ')[0]);
            int ySize = int.Parse(rawUserInput.Split(' ')[1]);

            return new PlateauSize(xSize, ySize);
        }
    }
}
