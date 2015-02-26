using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodToDelegate
{
    public static class DelegateExtensions
    {
        public static T ToDelegate<T>(this Delegate delg)
        {
            return (T) (object) delg.ToDelegate(typeof (T));
        }

        public static Delegate ToDelegate(this Delegate delg, Type delegateType)
        {
            return Delegate.CreateDelegate(delegateType, delg.Target, delg.Method);
        }
    }
}
