using System;
using System.Collections.Generic;
using Basel.Backend.Models;
using FileHelpers;
using System.Linq;

namespace Basel.Backend.BusinessLogic
{
    public class ComdirectParser //: BaseParser
    {
        private const int BookingDateIndex = 0;
        private const int ProcessDateIndex = 1;
        private const int AmountIndex = 4;
        private const int BokokingtextIndex = 3;

        private string _fileToParse;

        private bool _dataSuccessfullyParsed;
        private IEnumerable<ComdirectExpense> _parsedData;

        public ComdirectParser(string fileToParse) //: base(fileToParse)
        {
            _fileToParse = fileToParse;
        }

        public IEnumerable<ComdirectExpense> GetParsedData()
        {

            if (_dataSuccessfullyParsed)
            {
                return _parsedData;
            }
            else
            {
                throw new Exception("Data not paresed yet. Please parse data first.");
            }
        }

        public bool ParseData()
        {
            var engine = new FileHelperEngine<ComdirectExpense>();
            
            // Switch error mode on
            engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;

            // To Read Use:
            var result = engine.ReadFile(_fileToParse);

            _parsedData = result.Where(r => r.Amount < 0).ToList();

            // result is now an array of Customer

            // To Write Use:
            //engine.WriteFile("FileOut.txt", result);


            _dataSuccessfullyParsed = true;

            return _dataSuccessfullyParsed;

        }
    }
}
