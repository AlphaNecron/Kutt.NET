using System;

namespace Kutt.NET
{
    /// <summary>
    /// Kutt Exception Class
    /// </summary>
    public class KuttException : Exception
    {
        public KuttException(string message) : base(message)
        {
        }

        public override string StackTrace => "";
    }
}
