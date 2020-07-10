using System;

namespace FAS.Persistence
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class PkAttribute : Attribute
    {
    }
}
