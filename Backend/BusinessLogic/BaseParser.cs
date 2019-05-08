using Basel.Backend.Contracts;
using Basel.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basel.Backend.BusinessLogic
{
    public abstract class BaseParser : IParser
    {
        System.IO.FileInfo _fileToParse;

        public BaseParser()
        {
        }

        public BaseParser(string fileToParse)
        {
            _fileToParse = new System.IO.FileInfo(fileToParse);
        }

        public abstract IEnumerable<Expense> GetParsedData();

        public Task<IEnumerable<Expense>> GetParsedDataAsync()
        {
            throw new NotImplementedException();
        }

        public abstract bool ParseData();

        public Task<bool> ParseDataAsync()
        {
            throw new NotImplementedException();
        }
    }
}
