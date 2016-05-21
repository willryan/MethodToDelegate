using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MethodToDelegate.PartialApplication
{
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