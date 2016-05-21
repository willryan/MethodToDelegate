using System;
using System.Collections.Generic;
using System.Linq;
using MethodToDelegate.PartialApplication;
using MethodToDelegate.ReturnDelegate;
using NUnit.Framework;
using NUnit.Framework.Constraints;

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
            foreach (var buildInfo in types
                .SelectMany(DelegateHelper.GetDelegateTypesAndMethods)
                .Select(DelegateHelper.CreateBuildInfo))
            {
                var info = buildInfo;
                _typeProvider.Add(buildInfo.DelegateType, () => DelegateHelper.BuildDelegate(info, (t, args) => Get(t)));
            }
        }

        public void Load2(params Type[] types)
        {
            var delgs = types.SelectMany(t => 
                ReturnDelegateRegistrar.Register(t, pi => Get(pi.ParameterType))).ToArray();
            foreach (var delg in delgs)
            {
                _typeProvider.Add(delg.MethodInfo.ReturnType, delg.Producer);
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