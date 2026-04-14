using MarsRover.ConsoleApp.LogicLayer;
using MarsRover.ConsoleApp.Models;
using Shouldly;
namespace MarsRover.Tests;

public class RoverTests
{
    Rover defaultRover = new Rover(0,0,CompassDirection.N);

    [Test]
    public void Rotate_ReturnsN_MInput()
    {
        CompassDirection expected = CompassDirection.N;

        var result = defaultRover.Rotate(CompassDirection.N, Instruction.M);

        result.ShouldBe(expected);

    }
}
