using System;

namespace Kutt.NET
{
    /// <summary>
    /// Kutt Exception Class
    /// </summary>
    public class KuttException : Exception
    {
        /// <summary>
        /// Get Kutt Exception
        /// </summary>
        /// <param name="message">Error message</param>
        public KuttException(string message) : base(message)
        {
        }

        public override string StackTrace => "";
    }
}