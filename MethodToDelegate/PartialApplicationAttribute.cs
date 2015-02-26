using System;
using System.ComponentModel;

namespace MethodToDelegate
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    [ImmutableObject(true)]
    public sealed class PartialApplicationAttribute : Attribute
    {
        public readonly PartialApplicationInfo Info;
        public PartialApplicationAttribute(PartialApplicationType type, int appliedArity, int remainingArity)
        {
            Info = new PartialApplicationInfo(type, appliedArity, remainingArity);
        }
    }
}