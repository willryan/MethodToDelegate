using System;
using System.ComponentModel;

namespace DITest.Core
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    [ImmutableObject(true)]
    public sealed class CollectionAttribute : Attribute
    {
    }
}