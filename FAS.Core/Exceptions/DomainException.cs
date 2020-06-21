using System;

namespace FAS.Core.Exceptions
{
    public sealed class DomainException : Exception
    {
        public DomainException(string message) : base($"DomainException has been occured: {message}")
        {

        }
    }
}
