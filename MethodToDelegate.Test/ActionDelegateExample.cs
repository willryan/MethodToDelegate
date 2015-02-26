using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodToDelegate.Test
{
    public delegate void RepeatedlyAddToList(List<string> list, string elem, int times);

    public static class ActionDelegateExample
    {
        public delegate void AppendListToList(List<string> toChange, List<string> toAdd);

        public delegate List<string> Repeat(string elem, int times);

        [Implements(typeof(Repeat))]
        public static List<string> Repeatr(string elem, int times)
        {
            return Enumerable.Repeat(elem, times).ToList();
        }

        [Implements(typeof (AppendListToList))]
        public static void Appendr(List<string> toChange, List<string> toAdd)
        {
            toChange.AddRange(toAdd);
        }

        [Implements(typeof (RepeatedlyAddToList))]
        public static void RepAddr(Repeat repeater, AppendListToList appender, List<string> toChange, string elem, int times)
        {
            appender(toChange, repeater(elem, times));
        }
    }
}
