using System;
using System.ComponentModel;

namespace MethodToDelegate
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    [ImmutableObject(true)]
    public sealed class ImplementsAttribute : Attribute
    {
        public readonly Type Type;
        public ImplementsAttribute(Type t)
        {
            Type = t;
        }
    }
}