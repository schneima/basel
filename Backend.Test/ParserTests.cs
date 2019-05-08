using NUnit.Framework;
using Basel.Backend.BusinessLogic;
using Basel.Backend.Contracts;

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
            var expensesFile = "./TestData/expenses_sample.csv";
            var sut = new ComdirectParser(expensesFile);
            var success = sut.ParseData();

            Assert.True(success, "Parsing was not successful");

            var data = sut.GetParsedData();
            Assert.IsNotNull(data, "Returned data is null. Expected valid collection.");

        }
    }
}