using NUnit.Framework;
using Basel.Backend.BusinessLogic;
using Basel.Backend.Contracts;
using System.Linq;

namespace Tests
{
    public class ParserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReadTestData()
        {
            var expensesFile = "./TestData/comdirect_expenses_sample.csv";
            var sut = new ComdirectParser(expensesFile);
            var success = sut.ParseData();

            Assert.True(success, "Parsing was not successful");

            var data = sut.GetParsedData();
            Assert.IsNotNull(data, "Returned data is null. Expected valid collection.");
            Assert.IsTrue(data.ToList().Count > 0, "Parsed data is empty.");

        }
    }
}