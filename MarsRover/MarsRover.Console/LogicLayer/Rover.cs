using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp.LogicLayer
{
    public class Rover(int x, int y, CompassDirection facing)
    {
        public int X = x;
        public int Y = y;
        public CompassDirection Facing = facing;

        //Rotate takes current direction and instruction and modifies direction
        public CompassDirection Rotate(CompassDirection currentDirection, Instruction instuction)
        {
            switch (instuction)
            {
                case Instruction.L:

                break;

                case Instruction.R:

                break; 
            }

            return currentDirection;
                
        }


    }
}
