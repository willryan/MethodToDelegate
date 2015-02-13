using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
using Ninject.Activation.Caching;
using Ninject.Modules;
using Ninject.Syntax;

namespace DITest.Core
{
    public class DI
    {
        static DI()
        {
            DetermineModuleTypes();
            ResetNinjectKernel();
        }

        private static List<Type> _moduleTypes;
        private static IKernel _ninjectKernel;

        public static IKernel Kernel { get { return _ninjectKernel; }}

        public static object Get(Type t)
        {
            return _ninjectKernel.Get(t);
        }

        public static T Get<T>()
        {
            if (_ninjectKernel == null)
            {
                return default(T);
            }
            return _ninjectKernel.Get<T>(); 
        }

        public static void ResetNinjectKernel()
        {
            if (_ninjectKernel != null)
            {
               _ninjectKernel.GetModules()
                   .Where(m => m is NinjectModule).ToList()
                   .ForEach(m => _ninjectKernel.Unload(m.Name));
                _ninjectKernel.Components.Get<ICache>().Clear();
            }
            else
            {
                _ninjectKernel = new StandardKernel();
            }
            var modules = _moduleTypes
                .Select(t => (INinjectModule)t.GetConstructor(new Type[] {})
                .Invoke(new object[] {})).ToList();

            _ninjectKernel.Load(modules.ToArray());
        }

        public static IBindingToSyntax<T> Rebind<T>()
        {
            var binding = _ninjectKernel
                .GetBindings(typeof (T)).FirstOrDefault();
            if (binding == null)
            {
                return _ninjectKernel.Rebind<T>();
            }
            var mod =_ninjectKernel.GetModules()
                          .Where(m => m is NinjectModule)
                          .Cast<NinjectModule>()
                          .FirstOrDefault(m => m.Bindings.Contains(binding));
            return mod != null ? mod.Rebind<T>() : _ninjectKernel.Rebind<T>();
        }

        private static void DetermineModuleTypes()
        {
            _moduleTypes = new List<Type>();
            //_moduleTypes =
            //    (from assembly in AppDomain.CurrentDomain.GetAssemblies()
            //     from type in assembly.GetTypes()
            //     where type.IsSubclassOf(typeof (NinjectModule))
            //     select type).ToList();
        }

        public static IEnumerable<Type> GetTypesWith<TAttribute>(bool inherit)
                              where TAttribute : Attribute
        {
            return from a in AppDomain.CurrentDomain.GetAssemblies()
                   from t in a.GetTypes()
                   where t.IsDefined(typeof(TAttribute), inherit)
                   select t;
        }

        public static IEnumerable<Type> GetCollectionTypes<T>()
        {
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).ToArray();
            return types.Where(t =>
                {
                    var attr = t.GetCustomAttributes(typeof (CollectionAttribute), false)
                                .FirstOrDefault() as CollectionAttribute;
                    return (attr != null && t.IsSubclassOf(typeof (T)));
                });
        } 

        public static IEnumerable<T> GetCollection<T>()
        {
            return GetCollectionTypes<T>().Select(t => (T)_ninjectKernel.Get(t));
        } 
    }
}
