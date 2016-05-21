namespace MethodToDelegate.PartialApplication
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
}