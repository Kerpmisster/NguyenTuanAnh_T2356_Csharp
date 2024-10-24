using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._8
{
    public class AmountException : Exception
    {
        public AmountException() : base("Invalid amount") { }
        public AmountException(string message) : base(message) { }

        public AmountException(string message, Exception innerException) : base(message, innerException) { }
    }
}
