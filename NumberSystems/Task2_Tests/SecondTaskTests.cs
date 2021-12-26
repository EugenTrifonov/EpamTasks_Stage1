using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2tests
{
    [TestClass]
    public class Task2tests
    {
        [TestMethod]
        [DataRow("8", "2", "1000")]
        [DataRow("19", "20", "J")]
        [DataRow("115", "10", "115")]
        [DataRow("4", "3", "11")]
        [DataRow("0", "15", "0")]
        public void PositiveConverterTest(string value, string systemBase, string result)
        {
            Assert.AreEqual(result, Numbersystems.Numbers.ConvertNumber(new string[] { value, systemBase }));
        }
        
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        [DataRow("255","21")]
        [DataRow("255", "1")]
        [DataRow("-255", "2")]
        [DataRow("-255", "2")]
        public void ConverterIncorrectInput(string value,string systemBase) 
        {
            Numbersystems.Numbers.ConvertNumber(new string[] { value, systemBase });
        }
        
        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        [DataRow("sdfs", "21")]
        [DataRow("255", "sdfsf")]
        [DataRow("sdffsd", "sdfsfds")]
        public void ConverterIncorrectDataFormat(string value, string systemBase)
        {
            Numbersystems.Numbers.ConvertNumber(new string[] { value, systemBase });
        }
    }
}