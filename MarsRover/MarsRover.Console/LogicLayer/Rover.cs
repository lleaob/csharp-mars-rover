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

        public Rover Rotate(Instruction instruction)
        {
            switch (instruction)
            {
                case Instruction.L:
                    Facing = (CompassDirection)(((int)Facing + 3) % 4); // performing ciclical step by ref'ing the Object's enum by it's number then casting it back to a valid CompassDirection.
                    break;

                case Instruction.R:
                    Facing = (CompassDirection)(((int)Facing + 1) % 4);
                    break;
            }
            Console.WriteLine($"* Updated Rover *\r\nX = {X}: Y = {Y}: Facing: {Facing}");

            return this;
        }

        public Rover Move(Plateau plateau)
        {
            switch (Facing)
            {
                case CompassDirection.N:
                    if (Y == plateau.Y)
                    {
                        throw new Exception();
                    }
                    Y += 1;
                    break;

                case CompassDirection.E:
                    if (X == plateau.X) 
                    {
                        throw new Exception(); 
                    }
                    X += 1;
                    break;

                case CompassDirection.S:
                    if (Y == 0)
                    {
                        throw new Exception();
                    }
                    Y -= 1;
                    break;

                case CompassDirection.W:
                    if (X == 0)
                    {
                        throw new Exception();
                    }
                    X -= 1;
                    break;
            }
            Console.WriteLine($"* Updated Rover *\r\nX = {X}: Y = {Y}: Facing: {Facing}");
            return this;
        }

    }
}
