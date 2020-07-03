using System;

namespace FAS.Core.Exceptions
{
    public sealed class ObjectAlreadyExitsException : Exception
    {
        public ObjectAlreadyExitsException(string id, Type type) : base($"{type.FullName} with id: {id} is already exists")
        {

        }
    }
}
