using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.InputLayer;
using MarsRover.ConsoleApp;
using Shouldly;


namespace MarsRover.Tests
{
    public class PlateauParserTests
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
        [Test]
        public void NewPlateau_ReturnsZeroPlateauSize_SingleIntInput()
        {
            var expected = new PlateauSize(0,0);


            string rawUserInput = "1";

            var result = parser.NewPlateau(rawUserInput);

            result.ShouldBe(expected);
        }
        [Test]
        public void NewPlateau_ReturnsZeroPlateauSize_MoreThan2IntInput()
        {
            var expected = new PlateauSize(0, 0);


            string rawUserInput = "1 2 3";

            var result = parser.NewPlateau(rawUserInput);

            result.ShouldBe(expected);
        }
        [Test]
        public void NewPlateau_ReturnsZeroPlateauSize_2IntInputAndTrailingSpaces()
        {
            var expected = new PlateauSize(1, 2);

            string rawUserInput = "1 2                        ";

            var result = parser.NewPlateau(rawUserInput);

            result.ShouldBe(expected);
        }
        [Test]
        public void NewPlateau_ReturnsZeroPlateauSize_2StringsInput() 
        {
            var expected = new PlateauSize(0, 0);

            string rawUserInput = "a b";

            var result = parser.NewPlateau(rawUserInput);

            result.ShouldBe(expected);
        }
        [Test]
        public void NewPlateau_ReturnsZeroPlateauSize_1StringAnd1IntInput()
        {
            var expected = new PlateauSize(0, 0);

            string rawUserInput = "1 b";

            var result = parser.NewPlateau(rawUserInput);

            result.ShouldBe(expected);
        }

    }

}