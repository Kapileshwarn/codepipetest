using StructureMap;
using StructureMap.Configuration.DSL;
using WroxPizza.Core.Data;
using WroxPizza.Core.Data.Repositories;

namespace WroxPizza.Core.Web.Setup
{
    public class Bootstrapper
    {
        public static void Setup()
        {
            ObjectFactory.Initialize(c => c.AddRegistry(new WroxPizzaConfig()));
        }

        internal class WroxPizzaConfig : Registry
        {
            protected override void configure()
            {
                ForRequestedType<IProductRepository>().TheDefaultIsConcreteType<ProductRepository>();
                ForRequestedType<IDbConfigure>().TheDefaultIsConcreteType<DefaultNHibernateConfig>();
            }
        }
    }
}
