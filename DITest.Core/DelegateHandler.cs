using System;
using System.Linq;
using System.Reflection;
using Ninject.Infrastructure.Language;

namespace DITest.Core
{
    public static class DelegateHandler
    {
        public static void RegisterDelegates(Type type)
        {
            type.GetMethods(BindingFlags.Static | BindingFlags.Public).Select(methodInfo =>
            {
                return new
                {
                    Attribute = (ImplementsAttribute)CustomAttributeExtensions.GetCustomAttributes((MemberInfo) methodInfo).FirstOrDefault(a => a is ImplementsAttribute),
                    MethodInfo = methodInfo
                };
            })
                .Where(obj => obj.Attribute != null)
                .Select(obj =>
                {
                    var delgType = obj.Attribute.Type;
                    return new {Type = delgType, Provider = PartiallyApplyMethodToDelegate(delgType, obj.MethodInfo, DI.Get)};
                })
                .Map(obj => DI.Kernel.Bind(obj.Type).ToMethod(_ => obj.Provider()).InSingletonScope());
        }

        public static Func<object> PartiallyApplyMethodToDelegate(Type delgType, MethodInfo methodInfo,
            Func<Type, object> dependencyProvider)
        {
            var argCount = delgType.GetMethods().First().GetParameters().Count();
            var methodArgCount = methodInfo.GetParameters().Count();
            var depCount = methodArgCount - argCount;
            if (depCount == 0)
            {
                return () => methodInfo.CreateDelegate(delgType);
            }
            var makeGenericArgs =
                methodInfo.GetParameters()
                    .Select(p => p.ParameterType)
                    .Concat(new[] {methodInfo.ReturnType})
                    .ToArray();
            var funcType = PartialTable.GetFuncType(methodArgCount).MakeGenericType(makeGenericArgs);
            var methodDelg = methodInfo.CreateDelegate(funcType);
            var conversionFunc =
                PartialTable.GetMethod(depCount, argCount).MakeGenericMethod(makeGenericArgs);
            return () =>
            {
                var deps =
                    methodInfo.GetParameters()
                        .Take(depCount)
                        .Select(dep => DI.Get(dep.ParameterType))
                        .ToArray();
                var args = new object[deps.Length + 1];
                args[0] = methodDelg;
                Array.Copy(deps, 0, args, 1, deps.Length);
                var delgFunc = conversionFunc.Invoke(null, args);
                var delgFuncType = delgFunc.GetType();
                var delgMethod =
                    (MethodInfo) delgFuncType.GetProperty("Method").GetMethod.Invoke(delgFunc, new object[] {});
                var delgTarget = delgFuncType.GetProperty("Target").GetMethod.Invoke(delgFunc, new object[] {});
                return Delegate.CreateDelegate(delgType, delgTarget, delgMethod);
            };
        }
    }
}