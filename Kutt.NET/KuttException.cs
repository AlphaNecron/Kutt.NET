using System;

namespace Kutt.NET
{
    public class KuttException : Exception
    {
        public KuttException(string message) : base(message)
        {
        }

        public override string StackTrace => "";
    }
}