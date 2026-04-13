using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.InputLayer;
using MarsRover.ConsoleApp;
using Shouldly;


namespace MarsRover.Tests
{
    public class InstructionParserTests
    {
         InstructionParser parser = new();
        [Test]
        public void Instructions_ReturnsEmptyList_EmptyInput()
        {
            var expected = new List<Instruction> { };

            string rawUserInput = "";

            var result = parser.Instructions(rawUserInput);

            result.ShouldBe(expected);
        }
        [Test]
        public void Instructions_ReturnsListWithLMRRMInstructions_LMRRMInput()
        {
            var expected = new List<Instruction> {Instruction.L, Instruction.M, Instruction.R, Instruction.R, Instruction.M };

            string rawUserInput = "LMRRM";

            var result = parser.Instructions(rawUserInput);

            result.ShouldBe(expected);
        }
        [Test]
        public void Instructions_ReturnsListWithLMRRMInstructions_LMRHAJREAJEMInput()
        {
            var expected = new List<Instruction> { Instruction.L, Instruction.M, Instruction.R, Instruction.R, Instruction.M };

            string rawUserInput = "LMRHAJREAJEM";

            var result = parser.Instructions(rawUserInput);

            result.ShouldBe(expected);
        }
        [Test]
        public void Instructions_ReturnsListWithLMRRMInstructions_LMRHAJREAJEMLowercaseInput()
        {
            var expected = new List<Instruction> { Instruction.L, Instruction.M, Instruction.R, Instruction.R, Instruction.M };

            string rawUserInput = "LMRHAJREAJEM".ToLower();

            var result = parser.Instructions(rawUserInput);

            result.ShouldBe(expected);
        }
        [Test]
        public void Instructions_ReturnsAnEmptyList_OnlyNumbersInput()
        {
            var expected = new List<Instruction> { };

            string rawUserInput = "10928730491804325691";

            var result = parser.Instructions(rawUserInput);

            result.ShouldBe(expected);
        }


    }
}