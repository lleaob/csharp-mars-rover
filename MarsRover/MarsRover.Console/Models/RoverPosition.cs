using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp.Models
{
    public record RoverPosition (int X, int Y, CompassDirection Facing);
}
