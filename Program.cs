using System;

namespace CalculatorExceptions
{
    [System.Serializable]
    public class ParsingException : Exception
    {
        public ParsingException() { }
        public ParsingException(string message) : base(message) { }
    }

    [System.Serializable]
    public class InvalidExpressionException : Exception
    {
        public InvalidExpressionException() { }
        public InvalidExpressionException(string message) : base(message) { }
    }
}
