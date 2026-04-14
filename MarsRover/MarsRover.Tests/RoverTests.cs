using MarsRover.ConsoleApp.LogicLayer;
using MarsRover.ConsoleApp.Models;
using Shouldly;
namespace MarsRover.Tests;

public class RoverTests
{
    Rover defaultRover = new Rover(0,0,CompassDirection.N);

    [Test]
    public void Rotate_ReturnsN_InitialDirectionNorthRotateMInput()
    {
        var expected = CompassDirection.N;

        var result = defaultRover.Rotate(CompassDirection.N, Instruction.M);

        result.ShouldBe(expected);

    }
    [Test]
    public void Rotate_ReturnsE_InitialDirectionNorthRotateRInput()
    {
        var expected = CompassDirection.E;

        var result = defaultRover.Rotate(CompassDirection.N, Instruction.R);

        result.ShouldBe(expected);

    }
    [Test]
    public void Rotate_ReturnsW_InitialDirectionNorthRotateLInput()
    {
        var expected = CompassDirection.W;

        var result = defaultRover.Rotate(CompassDirection.N, Instruction.L);

        result.ShouldBe(expected);

    }
    [Test]
    public void Rotate_ReturnsS_InitialDirectionWRotateLInput()
    {
        var expected = CompassDirection.S;

        var result = defaultRover.Rotate(CompassDirection.W, Instruction.L);

        result.ShouldBe(expected);

    }
    [Test]
    public void Rotate_ReturnsS_InitialDirectionWRotateRInput()
    {
        var expected = CompassDirection.N;

        var result = defaultRover.Rotate(CompassDirection.W, Instruction.R);

        result.ShouldBe(expected);

    }
}
