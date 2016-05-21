using System;
using System.Linq;
using System.Reflection;

namespace MethodToDelegate.ReturnDelegate
{
    public struct RegisterableDelegate
    {
        public MethodInfo MethodInfo;
        public Func<object> Producer;
    }

    public static class ReturnDelegateRegistrar
    {
        public static RegisterableDelegate[] Register(Type t, Func<ParameterInfo,object> getFunc,
            Func<Type, MethodInfo, bool> filter = null)
        {
            return t.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(m => typeof(Delegate).IsAssignableFrom(m.ReturnType))
                .Where(m => m.GetCustomAttribute(typeof(ExcludeDelegateAttribute)) == null)
                .Where(m => filter == null || filter(t, m))
                .Select(m =>
                {
                    var parms = m.GetParameters();
                    return new RegisterableDelegate
                    {
                        MethodInfo = m,
                        Producer = () => m.Invoke(null, parms.Select(getFunc).ToArray())
                    };
                })
                .ToArray();
        }
    }
}