using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Ninject.Infrastructure.Language;

namespace MethodToDelegate
{
    public static class PartialSupport
    {
        public static Func<T1, T2, T3, T4, T5, TR> 
            Partial_5_5<TD1, TD2, TD3, TD4, TD5, T1, T2, T3, T4, T5, TR>(
                Func<TD1, TD2, TD3, TD4, TD5, T1, T2, T3, T4, T5, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5)
        {
            return (a, b, c, d, e) => f(td1, td2, td3, td4, td5, a, b, c, d, e);
        }

        public static Func<T1, T2, T3, T4, TR> 
            Partial_5_4<TD1, TD2, TD3, TD4, TD5, T1, T2, T3, T4, TR>(
                Func<TD1, TD2, TD3, TD4, TD5, T1, T2, T3, T4, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5)
        {
            return (a, b, c, d) => f(td1, td2, td3, td4, td5, a, b, c, d);
        }

        public static Func<T1, T2, T3, TR> 
            Partial_5_3<TD1, TD2, TD3, TD4, TD5, T1, T2, T3, TR>(
                Func<TD1, TD2, TD3, TD4, TD5, T1, T2, T3, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5)
        {
            return (a, b, c) => f(td1, td2, td3, td4, td5, a, b, c);
        }

        public static Func<T1, T2, TR> 
            Partial_5_2<TD1, TD2, TD3, TD4, TD5, T1, T2, TR>(
                Func<TD1, TD2, TD3, TD4, TD5, T1, T2, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5)
        {
            return (a, b) => f(td1, td2, td3, td4, td5, a, b);
        }

        public static Func<T1, TR> 
            Partial_5_1<TD1, TD2, TD3, TD4, TD5, T1, TR>(
                Func<TD1, TD2, TD3, TD4, TD5, T1, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5)
        {
            return (a) => f(td1, td2, td3, td4, td5, a);
        }

        public static Func<T1, T2, T3, T4, T5, TR> 
            Partial_4_5<TD1, TD2, TD3, TD4, T1, T2, T3, T4, T5, TR>(
                Func<TD1, TD2, TD3, TD4, T1, T2, T3, T4, T5, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4)
        {
            return (a, b, c, d, e) => f(td1, td2, td3, td4, a, b, c, d, e);
        }

        public static Func<T1, T2, T3, T4, TR> 
            Partial_4_4<TD1, TD2, TD3, TD4, T1, T2, T3, T4, TR>(
                Func<TD1, TD2, TD3, TD4, T1, T2, T3, T4, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4)
        {
            return (a, b, c, d) => f(td1, td2, td3, td4, a, b, c, d);
        }

        public static Func<T1, T2, T3, TR> 
            Partial_4_3<TD1, TD2, TD3, TD4, T1, T2, T3, TR>(
                Func<TD1, TD2, TD3, TD4, T1, T2, T3, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4)
        {
            return (a, b, c) => f(td1, td2, td3, td4, a, b, c);
        }

        public static Func<T1, T2, TR> 
            Partial_4_2<TD1, TD2, TD3, TD4, T1, T2, TR>(
                Func<TD1, TD2, TD3, TD4, T1, T2, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4)
        {
            return (a, b) => f(td1, td2, td3, td4, a, b);
        }

        public static Func<T1, TR> 
            Partial_4_1<TD1, TD2, TD3, TD4, T1, TR>(
                Func<TD1, TD2, TD3, TD4, T1, TR> f, 
                TD1 td1, TD2 td2, TD3 td3, TD4 td4)
        {
            return (a) => f(td1, td2, td3, td4, a);
        }

        public static Func<T1, T2, T3, T4, T5, TR> 
            Partial_3_5<TD1, TD2, TD3, T1, T2, T3, T4, T5, TR>(
                Func<TD1, TD2, TD3, T1, T2, T3, T4, T5, TR> f, 
                TD1 td1, TD2 td2, TD3 td3)
        {
            return (a, b, c, d, e) => f(td1, td2, td3, a, b, c, d, e);
        }

        public static Func<T1, T2, T3, T4, TR> 
            Partial_3_4<TD1, TD2, TD3, T1, T2, T3, T4, TR>(
                Func<TD1, TD2, TD3, T1, T2, T3, T4, TR> f, 
                TD1 td1, TD2 td2, TD3 td3)
        {
            return (a, b, c, d) => f(td1, td2, td3, a, b, c, d);
        }

        public static Func<T1, T2, T3, TR> 
            Partial_3_3<TD1, TD2, TD3, T1, T2, T3, TR>(
                Func<TD1, TD2, TD3, T1, T2, T3, TR> f, 
                TD1 td1, TD2 td2, TD3 td3)
        {
            return (a, b, c) => f(td1, td2, td3, a, b, c);
        }

        public static Func<T1, T2, TR> 
            Partial_3_2<TD1, TD2, TD3, T1, T2, TR>(
                Func<TD1, TD2, TD3, T1, T2, TR> f, 
                TD1 td1, TD2 td2, TD3 td3)
        {
            return (a, b) => f(td1, td2, td3, a, b);
        }

        public static Func<T1, TR> 
            Partial_3_1<TD1, TD2, TD3, T1, TR>(
                Func<TD1, TD2, TD3, T1, TR> f, 
                TD1 td1, TD2 td2, TD3 td3)
        {
            return (a) => f(td1, td2, td3, a);
        }

        public static Func<T1, T2, T3, T4, T5, TR> 
            Partial_2_5<TD1, TD2, T1, T2, T3, T4, T5, TR>(
                Func<TD1, TD2, T1, T2, T3, T4, T5, TR> f, 
                TD1 td1, TD2 td2)
        {
            return (a, b, c, d, e) => f(td1, td2, a, b, c, d, e);
        }

        public static Func<T1, T2, T3, T4, TR> 
            Partial_2_4<TD1, TD2, T1, T2, T3, T4, TR>(
                Func<TD1, TD2, T1, T2, T3, T4, TR> f, 
                TD1 td1, TD2 td2)
        {
            return (a, b, c, d) => f(td1, td2, a, b, c, d);
        }

        public static Func<T1, T2, T3, TR> 
            Partial_2_3<TD1, TD2, T1, T2, T3, TR>(
                Func<TD1, TD2, T1, T2, T3, TR> f, 
                TD1 td1, TD2 td2)
        {
            return (a, b, c) => f(td1, td2, a, b, c);
        }

        public static Func<T1, T2, TR> 
            Partial_2_2<TD1, TD2, T1, T2, TR>(
                Func<TD1, TD2, T1, T2, TR> f, 
                TD1 td1, TD2 td2)
        {
            return (a, b) => f(td1, td2, a, b);
        }

        public static Func<T1, TR> 
            Partial_2_1<TD1, TD2, T1, TR>(
                Func<TD1, TD2, T1, TR> f, 
                TD1 td1, TD2 td2)
        {
            return (a) => f(td1, td2, a);
        }

        public static Func<T1, T2, T3, T4, T5, TR> 
            Partial_1_5<TD1, T1, T2, T3, T4, T5, TR>(
                Func<TD1, T1, T2, T3, T4, T5, TR> f, 
                TD1 td1)
        {
            return (a, b, c, d, e) => f(td1, a, b, c, d, e);
        }

        public static Func<T1, T2, T3, T4, TR> 
            Partial_1_4<TD1, T1, T2, T3, T4, TR>(
                Func<TD1, T1, T2, T3, T4, TR> f, 
                TD1 td1)
        {
            return (a, b, c, d) => f(td1, a, b, c, d);
        }

        public static Func<T1, T2, T3, TR> 
            Partial_1_3<TD1, T1, T2, T3, TR>(
                Func<TD1, T1, T2, T3, TR> f, 
                TD1 td1)
        {
            return (a, b, c) => f(td1, a, b, c);
        }

        public static Func<T1, T2, TR> 
            Partial_1_2<TD1, T1, T2, TR>(
                Func<TD1, T1, T2, TR> f, 
                TD1 td1)
        {
            return (a, b) => f(td1, a, b);
        }

        public static Func<T1, TR> 
            Partial_1_1<TD1, T1, TR>(
                Func<TD1, T1, TR> f, 
                TD1 td1)
        {
            return (a) => f(td1, a);
        }

        public static Type GetFuncType(int numArgs)
        {
            switch (numArgs)
            {
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
    }

    public struct PartialIndex
    {
        public int DependencyArity;
        public int ArgumentArity;
    }

    public class PartialTable : Dictionary<PartialIndex, MethodInfo>
    {
        private static readonly Dictionary<PartialIndex, MethodInfo> Table = new Dictionary<PartialIndex, MethodInfo>();

        static PartialTable()
        {
            Enumerable.Range(1,5).Map(dependnecyArity => 
                Enumerable.Range(1,5).Map(argumentArity => 
                    AddIndex(Table, dependnecyArity, argumentArity)));
        }

        private static void AddIndex(Dictionary<PartialIndex, MethodInfo> dict, int dependencyArity, int argumentArity)
        {
            var name = string.Format("Partial_{0}_{1}", dependencyArity, argumentArity);
            dict.Add(new PartialIndex { DependencyArity = dependencyArity, ArgumentArity = argumentArity}, typeof(PartialSupport).GetMethod(name));
        }

        public static MethodInfo GetMethod(int dependencyArity, int argumentArity)
        {
            return Table[new PartialIndex {DependencyArity = dependencyArity, ArgumentArity = argumentArity}];
        }

    }
}
