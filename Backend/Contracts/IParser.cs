using Basel.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basel.Backend.Contracts
{
    public interface IParser
    {
        bool ParseData();

        Task<bool> ParseDataAsync();

        IEnumerable<Expense> GetParsedData();

        Task<IEnumerable<Expense>> GetParsedDataAsync();
    }
}
