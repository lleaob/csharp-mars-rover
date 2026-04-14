using MarsRover.ConsoleApp.LogicLayer;
using MarsRover.ConsoleApp.Models;
using Shouldly;
namespace MarsRover.Tests;

public class RoverTests
{

    [Test]
    public void Rotate_ReturnsN_InitialDirectionNorthRotateMInput()
    {
        var currentRover = new Rover(0, 0, CompassDirection.N);
        var expected = CompassDirection.N;

        var result = currentRover.Rotate(Instruction.M);

        result.Facing.ShouldBe(expected);

    }
    [Test]
    public void Rotate_ReturnsE_InitialDirectionNorthRotateRInput()
    {
        var currentRover = new Rover(0, 0, CompassDirection.N);
        var expected = CompassDirection.E;

        var result = currentRover.Rotate(Instruction.R);

        result.Facing.ShouldBe(expected);

    }
    [Test]
    public void Rotate_ReturnsW_InitialDirectionNorthRotateLInput()
    {
        var currentRover = new Rover(0, 0, CompassDirection.N);
        var expected = CompassDirection.W;

        var result = currentRover.Rotate(Instruction.L);

        result.Facing.ShouldBe(expected);

    }
    [Test]
    public void Rotate_ReturnsS_InitialDirectionWRotateLInput()
    {
        var currentRover = new Rover(0, 0, CompassDirection.W);
        var expected = CompassDirection.S;

        var result = currentRover.Rotate(Instruction.L);

        result.Facing.ShouldBe(expected);

    }
    [Test]
    public void Rotate_ReturnsS_InitialDirectionWRotateRInput()
    {
        var currentRover = new Rover(0, 0, CompassDirection.W);
        var expected = CompassDirection.N;

        var result = currentRover.Rotate(Instruction.R);

        result.Facing.ShouldBe(expected);

    }
    [Test]
    public void Move_Returns01_Position00North()
    {
        var currentRover = new Rover(0, 0, CompassDirection.N);
        var expected = new Rover(0, 1, CompassDirection.N);

        var result = currentRover.Move();

        result.Y.ShouldBe(expected.Y);

    }

}
