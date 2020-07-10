using System;

namespace FAS.Persistence
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class TableNameAttribute : Attribute
    {
        public string Name { get; }

        public TableNameAttribute(string name)
        {
            Name = name;
        }
    }
}
