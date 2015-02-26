using System;

namespace MethodToDelegate 
{
    public static class PartialExtensions 
    {
        [PartialApplication(PartialApplicationType.Func, 1,0)] 
        public static Func<TR> Apply<TD1, TR>(this Func<TD1, TR> func, TD1 td1) 
        {
            return () => func(td1);
        }

        [PartialApplication(PartialApplicationType.Action, 1,0)] 
        public static Action Apply<TD1>(this Action<TD1> act, TD1 td1) 
        {
            return () => act(td1);
        }
        [PartialApplication(PartialApplicationType.Func, 1,1)] 
        public static Func<TA1, TR> Apply<TD1, TA1, TR>(this Func<TD1, TA1, TR> func, TD1 td1) 
        {
            return (ta1) => func(td1, ta1);
        }

        [PartialApplication(PartialApplicationType.Action, 1,1)] 
        public static Action<TA1> Apply<TD1, TA1>(this Action<TD1, TA1> act, TD1 td1) 
        {
            return (ta1) => act(td1, ta1);
        }
        [PartialApplication(PartialApplicationType.Func, 1,2)] 
        public static Func<TA1, TA2, TR> Apply<TD1, TA1, TA2, TR>(this Func<TD1, TA1, TA2, TR> func, TD1 td1) 
        {
            return (ta1, ta2) => func(td1, ta1, ta2);
        }

        [PartialApplication(PartialApplicationType.Action, 1,2)] 
        public static Action<TA1, TA2> Apply<TD1, TA1, TA2>(this Action<TD1, TA1, TA2> act, TD1 td1) 
        {
            return (ta1, ta2) => act(td1, ta1, ta2);
        }
        [PartialApplication(PartialApplicationType.Func, 1,3)] 
        public static Func<TA1, TA2, TA3, TR> Apply<TD1, TA1, TA2, TA3, TR>(this Func<TD1, TA1, TA2, TA3, TR> func, TD1 td1) 
        {
            return (ta1, ta2, ta3) => func(td1, ta1, ta2, ta3);
        }

        [PartialApplication(PartialApplicationType.Action, 1,3)] 
        public static Action<TA1, TA2, TA3> Apply<TD1, TA1, TA2, TA3>(this Action<TD1, TA1, TA2, TA3> act, TD1 td1) 
        {
            return (ta1, ta2, ta3) => act(td1, ta1, ta2, ta3);
        }
        [PartialApplication(PartialApplicationType.Func, 1,4)] 
        public static Func<TA1, TA2, TA3, TA4, TR> Apply<TD1, TA1, TA2, TA3, TA4, TR>(this Func<TD1, TA1, TA2, TA3, TA4, TR> func, TD1 td1) 
        {
            return (ta1, ta2, ta3, ta4) => func(td1, ta1, ta2, ta3, ta4);
        }

        [PartialApplication(PartialApplicationType.Action, 1,4)] 
        public static Action<TA1, TA2, TA3, TA4> Apply<TD1, TA1, TA2, TA3, TA4>(this Action<TD1, TA1, TA2, TA3, TA4> act, TD1 td1) 
        {
            return (ta1, ta2, ta3, ta4) => act(td1, ta1, ta2, ta3, ta4);
        }
        [PartialApplication(PartialApplicationType.Func, 1,5)] 
        public static Func<TA1, TA2, TA3, TA4, TA5, TR> Apply<TD1, TA1, TA2, TA3, TA4, TA5, TR>(this Func<TD1, TA1, TA2, TA3, TA4, TA5, TR> func, TD1 td1) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => func(td1, ta1, ta2, ta3, ta4, ta5);
        }

        [PartialApplication(PartialApplicationType.Action, 1,5)] 
        public static Action<TA1, TA2, TA3, TA4, TA5> Apply<TD1, TA1, TA2, TA3, TA4, TA5>(this Action<TD1, TA1, TA2, TA3, TA4, TA5> act, TD1 td1) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => act(td1, ta1, ta2, ta3, ta4, ta5);
        }
        [PartialApplication(PartialApplicationType.Func, 2,0)] 
        public static Func<TR> Apply<TD1, TD2, TR>(this Func<TD1, TD2, TR> func, TD1 td1, TD2 td2) 
        {
            return () => func(td1, td2);
        }

        [PartialApplication(PartialApplicationType.Action, 2,0)] 
        public static Action Apply<TD1, TD2>(this Action<TD1, TD2> act, TD1 td1, TD2 td2) 
        {
            return () => act(td1, td2);
        }
        [PartialApplication(PartialApplicationType.Func, 2,1)] 
        public static Func<TA1, TR> Apply<TD1, TD2, TA1, TR>(this Func<TD1, TD2, TA1, TR> func, TD1 td1, TD2 td2) 
        {
            return (ta1) => func(td1, td2, ta1);
        }

        [PartialApplication(PartialApplicationType.Action, 2,1)] 
        public static Action<TA1> Apply<TD1, TD2, TA1>(this Action<TD1, TD2, TA1> act, TD1 td1, TD2 td2) 
        {
            return (ta1) => act(td1, td2, ta1);
        }
        [PartialApplication(PartialApplicationType.Func, 2,2)] 
        public static Func<TA1, TA2, TR> Apply<TD1, TD2, TA1, TA2, TR>(this Func<TD1, TD2, TA1, TA2, TR> func, TD1 td1, TD2 td2) 
        {
            return (ta1, ta2) => func(td1, td2, ta1, ta2);
        }

        [PartialApplication(PartialApplicationType.Action, 2,2)] 
        public static Action<TA1, TA2> Apply<TD1, TD2, TA1, TA2>(this Action<TD1, TD2, TA1, TA2> act, TD1 td1, TD2 td2) 
        {
            return (ta1, ta2) => act(td1, td2, ta1, ta2);
        }
        [PartialApplication(PartialApplicationType.Func, 2,3)] 
        public static Func<TA1, TA2, TA3, TR> Apply<TD1, TD2, TA1, TA2, TA3, TR>(this Func<TD1, TD2, TA1, TA2, TA3, TR> func, TD1 td1, TD2 td2) 
        {
            return (ta1, ta2, ta3) => func(td1, td2, ta1, ta2, ta3);
        }

        [PartialApplication(PartialApplicationType.Action, 2,3)] 
        public static Action<TA1, TA2, TA3> Apply<TD1, TD2, TA1, TA2, TA3>(this Action<TD1, TD2, TA1, TA2, TA3> act, TD1 td1, TD2 td2) 
        {
            return (ta1, ta2, ta3) => act(td1, td2, ta1, ta2, ta3);
        }
        [PartialApplication(PartialApplicationType.Func, 2,4)] 
        public static Func<TA1, TA2, TA3, TA4, TR> Apply<TD1, TD2, TA1, TA2, TA3, TA4, TR>(this Func<TD1, TD2, TA1, TA2, TA3, TA4, TR> func, TD1 td1, TD2 td2) 
        {
            return (ta1, ta2, ta3, ta4) => func(td1, td2, ta1, ta2, ta3, ta4);
        }

        [PartialApplication(PartialApplicationType.Action, 2,4)] 
        public static Action<TA1, TA2, TA3, TA4> Apply<TD1, TD2, TA1, TA2, TA3, TA4>(this Action<TD1, TD2, TA1, TA2, TA3, TA4> act, TD1 td1, TD2 td2) 
        {
            return (ta1, ta2, ta3, ta4) => act(td1, td2, ta1, ta2, ta3, ta4);
        }
        [PartialApplication(PartialApplicationType.Func, 2,5)] 
        public static Func<TA1, TA2, TA3, TA4, TA5, TR> Apply<TD1, TD2, TA1, TA2, TA3, TA4, TA5, TR>(this Func<TD1, TD2, TA1, TA2, TA3, TA4, TA5, TR> func, TD1 td1, TD2 td2) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => func(td1, td2, ta1, ta2, ta3, ta4, ta5);
        }

        [PartialApplication(PartialApplicationType.Action, 2,5)] 
        public static Action<TA1, TA2, TA3, TA4, TA5> Apply<TD1, TD2, TA1, TA2, TA3, TA4, TA5>(this Action<TD1, TD2, TA1, TA2, TA3, TA4, TA5> act, TD1 td1, TD2 td2) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => act(td1, td2, ta1, ta2, ta3, ta4, ta5);
        }
        [PartialApplication(PartialApplicationType.Func, 3,0)] 
        public static Func<TR> Apply<TD1, TD2, TD3, TR>(this Func<TD1, TD2, TD3, TR> func, TD1 td1, TD2 td2, TD3 td3) 
        {
            return () => func(td1, td2, td3);
        }

        [PartialApplication(PartialApplicationType.Action, 3,0)] 
        public static Action Apply<TD1, TD2, TD3>(this Action<TD1, TD2, TD3> act, TD1 td1, TD2 td2, TD3 td3) 
        {
            return () => act(td1, td2, td3);
        }
        [PartialApplication(PartialApplicationType.Func, 3,1)] 
        public static Func<TA1, TR> Apply<TD1, TD2, TD3, TA1, TR>(this Func<TD1, TD2, TD3, TA1, TR> func, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1) => func(td1, td2, td3, ta1);
        }

        [PartialApplication(PartialApplicationType.Action, 3,1)] 
        public static Action<TA1> Apply<TD1, TD2, TD3, TA1>(this Action<TD1, TD2, TD3, TA1> act, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1) => act(td1, td2, td3, ta1);
        }
        [PartialApplication(PartialApplicationType.Func, 3,2)] 
        public static Func<TA1, TA2, TR> Apply<TD1, TD2, TD3, TA1, TA2, TR>(this Func<TD1, TD2, TD3, TA1, TA2, TR> func, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1, ta2) => func(td1, td2, td3, ta1, ta2);
        }

        [PartialApplication(PartialApplicationType.Action, 3,2)] 
        public static Action<TA1, TA2> Apply<TD1, TD2, TD3, TA1, TA2>(this Action<TD1, TD2, TD3, TA1, TA2> act, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1, ta2) => act(td1, td2, td3, ta1, ta2);
        }
        [PartialApplication(PartialApplicationType.Func, 3,3)] 
        public static Func<TA1, TA2, TA3, TR> Apply<TD1, TD2, TD3, TA1, TA2, TA3, TR>(this Func<TD1, TD2, TD3, TA1, TA2, TA3, TR> func, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1, ta2, ta3) => func(td1, td2, td3, ta1, ta2, ta3);
        }

        [PartialApplication(PartialApplicationType.Action, 3,3)] 
        public static Action<TA1, TA2, TA3> Apply<TD1, TD2, TD3, TA1, TA2, TA3>(this Action<TD1, TD2, TD3, TA1, TA2, TA3> act, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1, ta2, ta3) => act(td1, td2, td3, ta1, ta2, ta3);
        }
        [PartialApplication(PartialApplicationType.Func, 3,4)] 
        public static Func<TA1, TA2, TA3, TA4, TR> Apply<TD1, TD2, TD3, TA1, TA2, TA3, TA4, TR>(this Func<TD1, TD2, TD3, TA1, TA2, TA3, TA4, TR> func, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1, ta2, ta3, ta4) => func(td1, td2, td3, ta1, ta2, ta3, ta4);
        }

        [PartialApplication(PartialApplicationType.Action, 3,4)] 
        public static Action<TA1, TA2, TA3, TA4> Apply<TD1, TD2, TD3, TA1, TA2, TA3, TA4>(this Action<TD1, TD2, TD3, TA1, TA2, TA3, TA4> act, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1, ta2, ta3, ta4) => act(td1, td2, td3, ta1, ta2, ta3, ta4);
        }
        [PartialApplication(PartialApplicationType.Func, 3,5)] 
        public static Func<TA1, TA2, TA3, TA4, TA5, TR> Apply<TD1, TD2, TD3, TA1, TA2, TA3, TA4, TA5, TR>(this Func<TD1, TD2, TD3, TA1, TA2, TA3, TA4, TA5, TR> func, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => func(td1, td2, td3, ta1, ta2, ta3, ta4, ta5);
        }

        [PartialApplication(PartialApplicationType.Action, 3,5)] 
        public static Action<TA1, TA2, TA3, TA4, TA5> Apply<TD1, TD2, TD3, TA1, TA2, TA3, TA4, TA5>(this Action<TD1, TD2, TD3, TA1, TA2, TA3, TA4, TA5> act, TD1 td1, TD2 td2, TD3 td3) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => act(td1, td2, td3, ta1, ta2, ta3, ta4, ta5);
        }
        [PartialApplication(PartialApplicationType.Func, 4,0)] 
        public static Func<TR> Apply<TD1, TD2, TD3, TD4, TR>(this Func<TD1, TD2, TD3, TD4, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return () => func(td1, td2, td3, td4);
        }

        [PartialApplication(PartialApplicationType.Action, 4,0)] 
        public static Action Apply<TD1, TD2, TD3, TD4>(this Action<TD1, TD2, TD3, TD4> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return () => act(td1, td2, td3, td4);
        }
        [PartialApplication(PartialApplicationType.Func, 4,1)] 
        public static Func<TA1, TR> Apply<TD1, TD2, TD3, TD4, TA1, TR>(this Func<TD1, TD2, TD3, TD4, TA1, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1) => func(td1, td2, td3, td4, ta1);
        }

        [PartialApplication(PartialApplicationType.Action, 4,1)] 
        public static Action<TA1> Apply<TD1, TD2, TD3, TD4, TA1>(this Action<TD1, TD2, TD3, TD4, TA1> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1) => act(td1, td2, td3, td4, ta1);
        }
        [PartialApplication(PartialApplicationType.Func, 4,2)] 
        public static Func<TA1, TA2, TR> Apply<TD1, TD2, TD3, TD4, TA1, TA2, TR>(this Func<TD1, TD2, TD3, TD4, TA1, TA2, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1, ta2) => func(td1, td2, td3, td4, ta1, ta2);
        }

        [PartialApplication(PartialApplicationType.Action, 4,2)] 
        public static Action<TA1, TA2> Apply<TD1, TD2, TD3, TD4, TA1, TA2>(this Action<TD1, TD2, TD3, TD4, TA1, TA2> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1, ta2) => act(td1, td2, td3, td4, ta1, ta2);
        }
        [PartialApplication(PartialApplicationType.Func, 4,3)] 
        public static Func<TA1, TA2, TA3, TR> Apply<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TR>(this Func<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1, ta2, ta3) => func(td1, td2, td3, td4, ta1, ta2, ta3);
        }

        [PartialApplication(PartialApplicationType.Action, 4,3)] 
        public static Action<TA1, TA2, TA3> Apply<TD1, TD2, TD3, TD4, TA1, TA2, TA3>(this Action<TD1, TD2, TD3, TD4, TA1, TA2, TA3> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1, ta2, ta3) => act(td1, td2, td3, td4, ta1, ta2, ta3);
        }
        [PartialApplication(PartialApplicationType.Func, 4,4)] 
        public static Func<TA1, TA2, TA3, TA4, TR> Apply<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TA4, TR>(this Func<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TA4, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1, ta2, ta3, ta4) => func(td1, td2, td3, td4, ta1, ta2, ta3, ta4);
        }

        [PartialApplication(PartialApplicationType.Action, 4,4)] 
        public static Action<TA1, TA2, TA3, TA4> Apply<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TA4>(this Action<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TA4> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1, ta2, ta3, ta4) => act(td1, td2, td3, td4, ta1, ta2, ta3, ta4);
        }
        [PartialApplication(PartialApplicationType.Func, 4,5)] 
        public static Func<TA1, TA2, TA3, TA4, TA5, TR> Apply<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TA4, TA5, TR>(this Func<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TA4, TA5, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => func(td1, td2, td3, td4, ta1, ta2, ta3, ta4, ta5);
        }

        [PartialApplication(PartialApplicationType.Action, 4,5)] 
        public static Action<TA1, TA2, TA3, TA4, TA5> Apply<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TA4, TA5>(this Action<TD1, TD2, TD3, TD4, TA1, TA2, TA3, TA4, TA5> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => act(td1, td2, td3, td4, ta1, ta2, ta3, ta4, ta5);
        }
        [PartialApplication(PartialApplicationType.Func, 5,0)] 
        public static Func<TR> Apply<TD1, TD2, TD3, TD4, TD5, TR>(this Func<TD1, TD2, TD3, TD4, TD5, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return () => func(td1, td2, td3, td4, td5);
        }

        [PartialApplication(PartialApplicationType.Action, 5,0)] 
        public static Action Apply<TD1, TD2, TD3, TD4, TD5>(this Action<TD1, TD2, TD3, TD4, TD5> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return () => act(td1, td2, td3, td4, td5);
        }
        [PartialApplication(PartialApplicationType.Func, 5,1)] 
        public static Func<TA1, TR> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TR>(this Func<TD1, TD2, TD3, TD4, TD5, TA1, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1) => func(td1, td2, td3, td4, td5, ta1);
        }

        [PartialApplication(PartialApplicationType.Action, 5,1)] 
        public static Action<TA1> Apply<TD1, TD2, TD3, TD4, TD5, TA1>(this Action<TD1, TD2, TD3, TD4, TD5, TA1> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1) => act(td1, td2, td3, td4, td5, ta1);
        }
        [PartialApplication(PartialApplicationType.Func, 5,2)] 
        public static Func<TA1, TA2, TR> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TR>(this Func<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1, ta2) => func(td1, td2, td3, td4, td5, ta1, ta2);
        }

        [PartialApplication(PartialApplicationType.Action, 5,2)] 
        public static Action<TA1, TA2> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TA2>(this Action<TD1, TD2, TD3, TD4, TD5, TA1, TA2> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1, ta2) => act(td1, td2, td3, td4, td5, ta1, ta2);
        }
        [PartialApplication(PartialApplicationType.Func, 5,3)] 
        public static Func<TA1, TA2, TA3, TR> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TR>(this Func<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1, ta2, ta3) => func(td1, td2, td3, td4, td5, ta1, ta2, ta3);
        }

        [PartialApplication(PartialApplicationType.Action, 5,3)] 
        public static Action<TA1, TA2, TA3> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3>(this Action<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1, ta2, ta3) => act(td1, td2, td3, td4, td5, ta1, ta2, ta3);
        }
        [PartialApplication(PartialApplicationType.Func, 5,4)] 
        public static Func<TA1, TA2, TA3, TA4, TR> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TA4, TR>(this Func<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TA4, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1, ta2, ta3, ta4) => func(td1, td2, td3, td4, td5, ta1, ta2, ta3, ta4);
        }

        [PartialApplication(PartialApplicationType.Action, 5,4)] 
        public static Action<TA1, TA2, TA3, TA4> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TA4>(this Action<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TA4> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1, ta2, ta3, ta4) => act(td1, td2, td3, td4, td5, ta1, ta2, ta3, ta4);
        }
        [PartialApplication(PartialApplicationType.Func, 5,5)] 
        public static Func<TA1, TA2, TA3, TA4, TA5, TR> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TA4, TA5, TR>(this Func<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TA4, TA5, TR> func, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => func(td1, td2, td3, td4, td5, ta1, ta2, ta3, ta4, ta5);
        }

        [PartialApplication(PartialApplicationType.Action, 5,5)] 
        public static Action<TA1, TA2, TA3, TA4, TA5> Apply<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TA4, TA5>(this Action<TD1, TD2, TD3, TD4, TD5, TA1, TA2, TA3, TA4, TA5> act, TD1 td1, TD2 td2, TD3 td3, TD4 td4, TD5 td5) 
        {
            return (ta1, ta2, ta3, ta4, ta5) => act(td1, td2, td3, td4, td5, ta1, ta2, ta3, ta4, ta5);
        }
    }
}