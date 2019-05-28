using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileHelpers;

namespace Basel.Backend.Models
{
    [DelimitedRecord(";")]
    public class ComdirectExpense
    {
        public Expense GetBaseExpenseRepresentation()
        {
            return new Expense();
        }

        [FieldConverter(ConverterKind.Date, "dd.MM.yyyy")]
        public DateTime BookingDate;

        [FieldConverter(ConverterKind.Date, "dd.MM.yyyy")]
        public DateTime ProcessDate;

        public string TransactionType;

        public string Bokokingtext;

        [FieldConverter(ConverterKind.Decimal, ",")]
        public decimal Amount;
    }
}
