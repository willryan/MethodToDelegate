using System;
using System.ComponentModel;

namespace MethodToDelegate.PartialApplication
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    [ImmutableObject(true)]
    public sealed class ToDelegateAttribute : Attribute
    {
        public readonly Type Type;
        public ToDelegateAttribute(Type t)
        {
            Type = t;
        }
    }
}