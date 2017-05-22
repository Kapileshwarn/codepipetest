using NHibernate;

namespace WroxPizza.Core.Data
{
    public interface IDbConfigure
    {
        ISessionFactory GetSessionFactory();
        ISession GetCurrentSession();
        string[] GenerateSchemaCreationScript();
    }
}