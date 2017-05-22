using NHibernate;
using NHibernate.Cfg;
using WroxPizza.Core.Data.Repositories;

namespace WroxPizza.Core.Data
{
    public class DefaultNHibernateConfig : IDbConfigure
    {
        private Configuration cfg;
        private ISession currentSession = null;
        public DefaultNHibernateConfig()
        {
            cfg = new Configuration();
            cfg.AddAssembly(typeof(ProductRepository).Assembly);

            NHibernateModel model = new NHibernateModel();
            model.Configure(cfg);
        }

        public ISessionFactory GetSessionFactory()
        {
            return cfg.BuildSessionFactory();
        }

        public ISession GetCurrentSession()
        {
            if (currentSession == null)
                currentSession = GetSessionFactory().OpenSession();

            return currentSession;
        }

        public string[] GenerateSchemaCreationScript()
        {
            return cfg.GenerateSchemaCreationScript(GetSessionFactory().Dialect);
        }
    }
}