using System.Collections.Generic;

namespace WroxPizza.Core.Data.Repositories
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, int> { }

    public interface IRepositoryWithTypedId<T, IdT>
    {
        T Get(IdT id);
        List<T> GetAll();
        List<T> FindAll(IDictionary<string, object> propertyValuePairs);
        T FindOne(IDictionary<string, object> propertyValuePairs);
        T SaveOrUpdate(T entity);
        void Delete(T entity);
    }
}