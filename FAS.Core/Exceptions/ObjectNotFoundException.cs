using System;

namespace FAS.Core.Exceptions
{
    public sealed class ObjectNotFoundException : Exception
    {
        public ObjectNotFoundException(string id, Type type) : base($"Object: {type.FullName} with id: {id} not found")
        {

        }
    }
}
