using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructuur.Exceptions
{
    public class HtmlParserException : Exception
    {
        public HtmlParserException() : this("An error occurred during HTML parsing.")
        {
        }
        public HtmlParserException(string message) : base(message)
        {
        }

        public HtmlParserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
