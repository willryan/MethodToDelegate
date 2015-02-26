using System;
using System.ComponentModel;

namespace MethodToDelegate
{

    public enum PartialApplicationType
    {
        Func,
        Action
    }

    public struct PartialApplicationInfo
    {
        public readonly int AppliedArity;
        public readonly int RemainingArity;
        public readonly PartialApplicationType Type;

        public PartialApplicationInfo(PartialApplicationType type, int appliedArity, int remainingArity)
        {
            Type = type;
            AppliedArity = appliedArity;
            RemainingArity = remainingArity;
        }
    }

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