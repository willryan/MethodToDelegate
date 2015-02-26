using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MethodToDelegate
{
    public static class PartialSupport
    {
        public static Type GetFuncType(PartialApplicationType type, int numArgs)
        {
            if (type == PartialApplicationType.Func)
            {
                switch (numArgs)
                {
                    case 1:
                        return typeof (Func<,>);
                    case 2:
                        return typeof (Func<,,>);
                    case 3:
                        return typeof (Func<,,,>);
                    case 4:
                        return typeof (Func<,,,,>);
                    case 5:
                        return typeof (Func<,,,,,>);
                    case 6:
                        return typeof (Func<,,,,,,>);
                    case 7:
                        return typeof (Func<,,,,,,,>);
                    case 8:
                        return typeof (Func<,,,,,,,,>);
                    case 9:
                        return typeof (Func<,,,,,,,,,>);
                    case 10:
                        return typeof (Func<,,,,,,,,,,>);
                    default:
                        return null;
                }
            }
            else
            {
                switch (numArgs)
                {
                    case 1:
                        return typeof (Action<>);
                    case 2:
                        return typeof (Action<,>);
                    case 3:
                        return typeof (Action<,,>);
                    case 4:
                        return typeof (Action<,,,>);
                    case 5:
                        return typeof (Action<,,,,>);
                    case 6:
                        return typeof (Action<,,,,,>);
                    case 7:
                        return typeof (Action<,,,,,,>);
                    case 8:
                        return typeof (Action<,,,,,,,>);
                    case 9:
                        return typeof (Action<,,,,,,,,>);
                    case 10:
                        return typeof (Action<,,,,,,,,,>);
                    default:
                        return null;
                }
            }
        }
    }
    public class PartialTable : Dictionary<PartialApplicationInfo, MethodInfo>
    {
        private static readonly Dictionary<PartialApplicationInfo, MethodInfo> Table = new Dictionary<PartialApplicationInfo, MethodInfo>();

        static PartialTable()
        {
            var attrInfos = typeof (PartialExtensions).GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Select(m => new
                        {
                            MethodInfo = m,
                            Attr = m.GetCustomAttributes(typeof (PartialApplicationAttribute)).Cast<PartialApplicationAttribute>().FirstOrDefault()
                        })
                .Where(i => i.Attr != null);
            foreach (var attrInfo in attrInfos)
            {
                Table.Add(attrInfo.Attr.Info, attrInfo.MethodInfo );
            }
        }

        public static MethodInfo GetMethod(PartialApplicationInfo info)
        {
            return Table[info];
        }

    }
}
