using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class RegexProblemCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT
        }
        public ExceptionType type;
        public RegexProblemCustomException(ExceptionType type, string message):base(message)
        {
            this.type = type;
        }
    }
}
