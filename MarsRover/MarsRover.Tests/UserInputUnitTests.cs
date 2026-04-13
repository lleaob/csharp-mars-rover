using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.InputLayer;
using MarsRover.ConsoleApp;
using Shouldly;


namespace MarsRover.Tests
{
    public class Tests
    {
        PlateauParser parser = new PlateauParser();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewPlateau_ReturnsZeroPlateauSize_EmptyInput()
        {
            var expected = new PlateauSize(0, 0);

            string[] userInputPlateauSize = [""];
            
            var result = parser.NewPlateau(userInputPlateauSize);

            result.ShouldBe(expected);


        }
    }
}