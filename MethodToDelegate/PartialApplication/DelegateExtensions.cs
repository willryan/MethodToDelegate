using System;

namespace MethodToDelegate.PartialApplication
{
    public static class DelegateExtensions
    {
        public static T ToDelegate<T>(this Delegate delg)
        {
            return (T) (object) delg.ToDelegate(typeof (T));
        }

        public static Delegate ToDelegate(this Delegate delg, Type delegateType)
        {
            return Delegate.CreateDelegate(delegateType, delg.Target, delg.Method);
        }

        public static bool IsDelegate(this Type type)
        {
            return type.IsSubclassOf(typeof (Delegate));
        }
    }
}
