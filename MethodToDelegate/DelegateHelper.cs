using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MethodToDelegate
{
    public delegate object ProvideDependency(Type dependencyType);

    public struct DelegateTypeAndMethodInfo
    {
        public Type DelegateType;
        public MethodInfo MethodInfo;
    }

    public struct DelegateBuildInfo
    {
        public Type DelegateType;
        public Delegate MethodDelegate;
        public MethodInfo ConversionFunc;
        public Type[] DependencyTypes;
    }

    public static class DelegateHelper
    {
        public static IEnumerable<DelegateTypeAndMethodInfo> GetDelegateTypesAndMethods(Type type)
        {
            return type.GetMethods(BindingFlags.Static | BindingFlags.Public)
                .Select(methodInfo =>
                {
                    var attribute =
                        (ImplementsAttribute) methodInfo.GetCustomAttributes().FirstOrDefault(a => a is ImplementsAttribute);
                    var delgType = attribute != null ? attribute.Type : null;
                    return new DelegateTypeAndMethodInfo {DelegateType = delgType, MethodInfo = methodInfo};
                })
                .Where(obj => obj.DelegateType != null);
        }

        public static DelegateBuildInfo CreateBuildInfo(Type delgType, MethodInfo methodInfo)
        {
            var argCount = delgType.GetMethods().First().GetParameters().Count();
            var methodArgCount = methodInfo.GetParameters().Count();
            var depCount = methodArgCount - argCount;
            if (depCount == 0)
            {
                return new DelegateBuildInfo
                {
                    DelegateType = delgType,
                    MethodDelegate = methodInfo.CreateDelegate(delgType)
                };
            }
            var makeGenericArgs =
                methodInfo.GetParameters()
                    .Select(p => p.ParameterType)
                    .Concat(new[] {methodInfo.ReturnType})
                    .ToArray();
            var funcType = PartialSupport.GetFuncType(methodArgCount).MakeGenericType(makeGenericArgs);
            var methodDelg = methodInfo.CreateDelegate(funcType);
            var conversionFunc = PartialTable.GetMethod(depCount, argCount).MakeGenericMethod(makeGenericArgs);

            var depTypes =
                methodInfo.GetParameters()
                    .Take(depCount)
                    .Select(d => d.ParameterType)
                    .ToArray();
            return new DelegateBuildInfo
            {
                ConversionFunc = conversionFunc,
                DelegateType = delgType,
                DependencyTypes = depTypes,
                MethodDelegate = methodDelg
            };
        }

        public static object BuildDelegate(DelegateBuildInfo info, ProvideDependency dependencyProvider)
        {
            if (info.ConversionFunc == null)
            {
                return info.MethodDelegate;
            }
            var deps =
                info.DependencyTypes
                    .Select(x => dependencyProvider(x))
                    .ToArray();
            var args = new object[info.DependencyTypes.Length + 1];
            args[0] = info.MethodDelegate;
            Array.Copy(deps, 0, args, 1, deps.Length);
            var delgFunc = info.ConversionFunc.Invoke(null, args);
            var delgFuncType = delgFunc.GetType();
            var delgMethod =
                (MethodInfo) delgFuncType.GetProperty("Method").GetMethod.Invoke(delgFunc, new object[] {});
            var delgTarget = delgFuncType.GetProperty("Target").GetMethod.Invoke(delgFunc, new object[] {});
            return Delegate.CreateDelegate(info.DelegateType, delgTarget, delgMethod);
        }
    }

}