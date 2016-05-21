using System;
using System.Linq;
using MethodToDelegate.PartialApplication;

namespace MethodToDelegate.Test.PartialApplication
{
    public delegate T3 Combine<T1,T2,T3>(T1 one, T2 two);

    public static class GenericDelegateExample
    {
        public delegate T3 AdjustOne<T1,T3>(T1 one);
        public delegate T3 AdjustTwo<T2,T3>(T2 twi);

        [ToDelegate(typeof(AdjustOne<,>))]
        public static T3 AdjOne<T1,T3>(T1 changeMe)
        {
            if (typeof (T3) == typeof (int))
            {
                int value = (typeof (T1) == typeof (int))
                    ? (int) (object) changeMe
                    : int.Parse((string) (object) changeMe);
                return (T3)(object)(value + 1);
            }
            else if (typeof (T3) == typeof (string))
            {
                return (T3) (object) (((object) changeMe).ToString() + "ONE");
            }
            throw new Exception("NOPE");
        }

        [ToDelegate(typeof(AdjustTwo<,>))]
        public static T3 AdjTwo<T2,T3>(T2 changeMe)
        {
            if (typeof (T3) == typeof (int))
            {
                int value = (typeof (T2) == typeof (int))
                    ? (int) (object) changeMe
                    : int.Parse((string) (object) changeMe);
                return (T3)(object)(value + 2);
            }
            else if (typeof (T3) == typeof (string))
            {
                return (T3) (object) (((object) changeMe).ToString() + "TWO");
            }
            throw new Exception("NOPE");
        }

        [ToDelegate(typeof (Combine<,,>))]
        public static T3 Combiner<T1, T2, T3>(AdjustOne<T1, T3> adj1, AdjustTwo<T2, T3> adj2, T1 t1, T2 t2)
        {
            var t3s = new[] {adj1(t1), adj2(t2)};
            if (typeof (T3) == typeof (int))
            {
                return (T3)(object)t3s.Cast<int>().Sum();
            }
            else if (typeof (T3) == typeof (string))
            {
                return (T3) (object) string.Join(":", t3s.Cast<string>());
            }
            throw new Exception("NOPE");
        }

    }
}
