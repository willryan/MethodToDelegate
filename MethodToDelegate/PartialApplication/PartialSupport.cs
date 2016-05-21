using System;

namespace MethodToDelegate.PartialApplication
{
    public static class PartialSupport
    {
        public static Type GetFuncType(PartialApplicationType type, int numArgs)
        {
            if (type == PartialApplicationType.Func)
            {
                switch (numArgs)
                {
                    case 0: return typeof(Func<>);
                    case 1: return typeof (Func<,>);
                    case 2: return typeof (Func<,,>);
                    case 3: return typeof (Func<,,,>);
                    case 4: return typeof (Func<,,,,>);
                    case 5: return typeof (Func<,,,,,>);
                    case 6: return typeof (Func<,,,,,,>);
                    case 7: return typeof (Func<,,,,,,,>);
                    case 8: return typeof (Func<,,,,,,,,>);
                    case 9: return typeof (Func<,,,,,,,,,>);
                    case 10: return typeof (Func<,,,,,,,,,,>);
                    default: return null;
                }
            }
            else
            {
                switch (numArgs)
                {
                    case 0: return typeof(Action);
                    case 1: return typeof (Action<>);
                    case 2: return typeof (Action<,>);
                    case 3: return typeof (Action<,,>);
                    case 4: return typeof (Action<,,,>);
                    case 5: return typeof (Action<,,,,>);
                    case 6: return typeof (Action<,,,,,>);
                    case 7: return typeof (Action<,,,,,,>);
                    case 8: return typeof (Action<,,,,,,,>);
                    case 9: return typeof (Action<,,,,,,,,>);
                    case 10: return typeof (Action<,,,,,,,,,>);
                    default: return null;
                }
            }
        }
    }
}
