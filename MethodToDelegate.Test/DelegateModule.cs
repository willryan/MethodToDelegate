using Ninject.Infrastructure.Language;
using Ninject.Modules;

namespace MethodToDelegate
{
    public class DelegateModule : NinjectModule
    {
        public override void Load()
        {
            var bindEm = DelegateHelper.GetDelegateTypesAndMethods(typeof (DelegateExample));
            bindEm.Map(info =>
            {
                Bind(info.DelegateType).ToPartiallyAppliedMethodInfo(info.MethodInfo);
            });
        }
    }
}