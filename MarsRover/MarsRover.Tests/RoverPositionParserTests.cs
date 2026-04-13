using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.InputLayer;
using Shouldly;

namespace MarsRover.Tests;

public class RoverPositionParserTests
{
    RoverPositionParser parser = new();
    [Test]
    public void NewRover_ReturnsDefaultPosition_EmptystringInput()
    {
        RoverPosition expected = new(0, 0, CompassDirection.N);

        var result = parser.NewRover("");

        result.ShouldBe(expected);

    }
    [Test]
    public void NewRover_Returns11E_11EInput()
    {
        RoverPosition expected = new(1, 1, CompassDirection.E);

        var result = parser.NewRover("1 1 E");

        result.ShouldBe(expected);

    }
    [Test]
    public void NewRover_ReturnsDefault00N_11EEInput()
    {
        RoverPosition expected = new(0, 0, CompassDirection.N);

        var result = parser.NewRover("1 1 E E");

        result.ShouldBe(expected);

    }
    [Test]
    public void NewRover_ReturnsDefault00N_111EEInput()
    {
        RoverPosition expected = new(0, 0, CompassDirection.N);

        var result = parser.NewRover("1 1 1 E E");

        result.ShouldBe(expected);

    }
    [Test]
    public void NewRover_ReturnsDefault00N_NoSpaceInput()
    {
        RoverPosition expected = new(0, 0, CompassDirection.N);

        var result = parser.NewRover("11E");

        result.ShouldBe(expected);

    }
    [Test]
    public void NewRover_ReturnsDefault00N_OutOfOrderInput()
    {
        RoverPosition expected = new(0, 0, CompassDirection.N);

        var result = parser.NewRover("1E1");

        result.ShouldBe(expected);

    }
}
