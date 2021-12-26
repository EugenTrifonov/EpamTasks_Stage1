using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Firsttasktests
{
    [TestClass]
    public class FirstTaskTests
    {
        [TestMethod]
        [DataRow("abcdefa", 6)]
        [DataRow("11", 1)]
        [DataRow("asdfga", 5)]
        [DataRow("", 0)]
        public void PositiveGetTheLongestUnequalCharacterNumber(string input, int expectedLength)
        {
            Assert.AreEqual(expectedLength, Unequalcharacters.UnequalCharactersSequence.GetMaxNumberofUnequalCharacters(new string[] { input }));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        [DataRow(new string[] { "dfsdf", "adasdada", "dsfsf" })]
        public void GetTheLongestUnequalCharacterNumberIncorrectInput(string[] input)
        {
            Unequalcharacters.UnequalCharactersSequence.GetMaxNumberofUnequalCharacters(input);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        [DataRow(new string[] { })]
        public void GetTheLongestUnequalCharacterNumberEmptyInput(string[] input)
        {
            Unequalcharacters.UnequalCharactersSequence.GetMaxNumberofUnequalCharacters(input);
        }
    }
}
