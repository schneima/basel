using Basel.Backend.Models;
using System.Collections.Generic;

namespace Basel.Backend.Contracts
{
    interface PersistenceAccess
    {
        bool WriteData(IEnumerable<Expense> expenses);
        IEnumerable<Expense> GetAllExpenses();
    }
}
