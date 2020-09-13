using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBankSolution.Utilities.Exceptions
{
    public class ShopBankException : Exception
    {
        public ShopBankException()
        {
        }

        public ShopBankException(string message)
            : base(message)
        {
        }

        public ShopBankException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
