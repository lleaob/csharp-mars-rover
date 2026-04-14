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
                PlateauSize newPlateau = new(int.Parse(strings[0]), int.Parse(strings[1]));
                return newPlateau;
            }
            catch (Exception)
            {
                return new PlateauSize(0,0);
            }
        }
    }
}
