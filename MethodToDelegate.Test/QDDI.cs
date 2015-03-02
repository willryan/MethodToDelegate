using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodToDelegate.Test
{
    public class QDDI
    {
        private readonly Dictionary<Type, Func<object>> _typeProvider;

        public QDDI()
        {
            _typeProvider = new Dictionary<Type, Func<object>>();
        }

        public void Load(params Type[] types)
        {
            foreach (var buildInfo in types.SelectMany(DelegateHelper.GetDelegateTypesAndMethods).Select(DelegateHelper.CreateBuildInfo))
            {
                var info = buildInfo;
                _typeProvider.Add(buildInfo.DelegateType, () => DelegateHelper.BuildDelegate(info, Get));
            }
        }

        public object Get(Type t)
        {
            return _typeProvider[t]();
        }

        public T Get<T>()
        {
            return (T)Get(typeof (T));
        }
    }
}