using System;

namespace Basel.Backend.Models
{
    public class Expense
    {
        /// <summary>
        /// Identifier to be able to assign expense to a specific account.
        /// </summary>
        public int AccountId { get; set; }
        
        /// <summary>
        /// Date when amount was booked.
        /// </summary>
        public DateTime BookingDate { get; set; }

        /// <summary>
        /// Daten when booked amount was processed.
        /// </summary>
        public DateTime ProcessDate { get; set; }

        /// <summary>
        /// Processed amount.
        /// </summary>
        public Decimal Amount { get; set; }

        /// <summary>
        /// Kind of action amount was used for.
        /// </summary>
        public String Category { get; set; }

        /// <summary>
        /// Original text by export provided by financial institute.
        /// </summary>
        public String Bookingtext  { get; set; }

        /// <summary>
        /// User description of financial transaction.
        /// </summary>
        public String Description { get; set; }
    }
}
