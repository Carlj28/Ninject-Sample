using Ninject.Modules;
using Ninject_Sample.DB;
using Ninject_Sample.Interfaces;

namespace Ninject_Sample.DI
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
#if DEBUG
            Bind<IDBConection>().To<LocalDB>();
#else
            Bind<IDBConection>().To<ProductionDB>();
#endif
        }
    }
}
