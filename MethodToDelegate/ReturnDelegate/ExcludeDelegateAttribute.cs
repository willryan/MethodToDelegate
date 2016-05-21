using System;
using System.ComponentModel;

namespace MethodToDelegate.ReturnDelegate
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    [ImmutableObject(true)]
    public sealed class ExcludeDelegateAttribute : Attribute
    {
    }
}