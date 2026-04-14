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

        // Rotate takes current direction and instruction and modifies direction
        public Rover Rotate(Instruction instruction)
        {

            switch (instruction)
            {
                case Instruction.L:
                    Facing = (CompassDirection)(((int)Facing + 3) % 4);
                    break;

                case Instruction.R:
                    Facing = (CompassDirection)(((int)Facing + 1) % 4);
                    break;
            }
            return this;
        }

        // Move takes current position and returns updated coordinates
        public Rover Move()
        {
            switch (Facing)
            {
                case CompassDirection.N:
                    Y += 1;
                    break;

                case CompassDirection.E:
                    X += 1;
                    break;

                case CompassDirection.S:
                    Y -= 1;
                    break;

                case CompassDirection.W:
                    X -= 1;
                    break;
            }

            return this;
        }

    }
}
