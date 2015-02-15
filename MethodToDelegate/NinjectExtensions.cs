using System.Reflection;
using Ninject;
using Ninject.Planning.Bindings;
using Ninject.Syntax;

namespace MethodToDelegate
{
    public static class NinjectExtensions
    {
        public static IBindingWhenInNamedWithOrOnSyntax<object> ToPartiallyAppliedMethodInfo(
            this IBindingToSyntax<object> binder, MethodInfo methodInfo)
        {
            var betterBinder = binder as BindingBuilder<object>;
            if (betterBinder != null)
            {
                var buildInfo = DelegateHelper.CreateBuildInfo(betterBinder.Binding.Service, methodInfo);
                return binder.ToMethod(ctx =>
                    DelegateHelper.BuildDelegate(buildInfo, t => ctx.Kernel.Get(t)));
            }
            throw new MethodBindingException("cannot determine delegate type to bind");
        }
    }
}