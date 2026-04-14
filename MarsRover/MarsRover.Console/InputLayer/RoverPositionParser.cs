using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp.InputLayer
{
    public class RoverPositionParser
    {
        public RoverPosition NewRover(string rawUserInput)
        {
            string[] strings = rawUserInput.Trim().ToUpper().Split(' ');           
            try
            {
                if (strings.Length != 3)
                {
                    throw new Exception();
                }
                string roverPositionX = strings[0];
                string roverPositionY = strings[1];
                string roverDirection = strings[2];

                CompassDirection roverFacing = CompassDirection.N;

                switch (roverDirection)
                {
                    case "N":
                        roverFacing = CompassDirection.N;
                        break;
                    case "E":
                        roverFacing = CompassDirection.E;
                        break;
                    case "S":
                        roverFacing = CompassDirection.S;
                        break;
                    case "W":
                        roverFacing = CompassDirection.W;
                        break;
                    default:
                        roverFacing = CompassDirection.N;
                        Console.WriteLine($"No valid direction was found. Using default direction {roverFacing}. Only Compass Directions N, E, S or W are allowed.");
                        break;
                }
                RoverPosition newRoverPosition = new(int.Parse(roverPositionX), int.Parse(roverPositionY), roverFacing);
                return newRoverPosition;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Rover position. Please review your input. Expected: \"X Y Compass_Direction_Letter\"");
                return new RoverPosition(0, 0, CompassDirection.N);
            }
        }
    }
}
