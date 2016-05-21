using System;
using System.Linq;
using System.Reflection;

namespace MethodToDelegate.ReturnDelegate
{
    public struct RegisterableDelegate<TContext>
    {
        public MethodInfo MethodInfo;
        public Func<TContext,object> Producer;
    }

    public static class ReturnDelegateRegistrar
    {
        public static RegisterableDelegate<TContext>[] Register<TContext>(Type t, Func<TContext,ParameterInfo,object> getFunc,
            Func<Type, MethodInfo, bool> filter = null)
        {
            return t.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(m => typeof(Delegate).IsAssignableFrom(m.ReturnType))
                .Where(m => m.GetCustomAttribute(typeof(ExcludeDelegateAttribute)) == null)
                .Where(m => filter == null || filter(t, m))
                .Select(m =>
                {
                    var parms = m.GetParameters();
                    return new RegisterableDelegate<TContext>
                    {
                        MethodInfo = m,
                        Producer = ctx => 
                            m.Invoke(null, parms.Select(p => getFunc(ctx, p)).ToArray())
                    };
                })
                .ToArray();
        }
    }
}