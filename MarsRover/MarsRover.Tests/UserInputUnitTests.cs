using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.InputLayer;
using MarsRover.ConsoleApp;
using Shouldly;


namespace MarsRover.Tests
{
    public class Tests
    {
        PlateauParser parser = new PlateauParser();

        [Test]
        public void NewPlateau_ReturnsZeroPlateauSize_EmptyInput()
        {
            var expected = new PlateauSize(0, 0);

            string rawUserInput = "";
            
            var result = parser.NewPlateau(rawUserInput);

            result.ShouldBe(expected);


        }
        [Test]
        public void NewPlateau_ReturnsNewPlateauWithSpecifiedSize_10and10Input()
        {
            var expected = new PlateauSize(10, 10);

            string rawUserInput = "10 10";

            var result = parser.NewPlateau(rawUserInput);

            result.ShouldBe(expected);


        }

    }
}