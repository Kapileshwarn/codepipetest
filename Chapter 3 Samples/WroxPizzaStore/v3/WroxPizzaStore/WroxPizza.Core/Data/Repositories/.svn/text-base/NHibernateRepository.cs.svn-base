using System;
using System.Collections.Generic;
using FluentNHibernate;
using NHibernate;
using NHibernate.Criterion;
using WroxPizza.Core.Data.Mapping;

namespace WroxPizza.Core.Data.Repositories
{
    /// <summary>
    /// This is used for Fluent NHibernate to register the mappings
    /// </summary>
    public class NHibernateModel : PersistenceModel
    {
        public NHibernateModel()
        {
            addMappingsFromAssembly(typeof(ProductMap).Assembly);
        }
    }

    public class NHibernateRepository<T> : IRepository<T>, IDisposable
    {
        private IDbConfigure Factory;
        public NHibernateRepository(IDbConfigure factory)
        {
            Factory = factory;
        }

        public virtual ISession Session
        {
            get
            {
                ISession s = Factory.GetCurrentSession();

                return s;
            }
        }

        public T Get(int id)
        {
            ICriteria criteria = Session.CreateCriteria(typeof(T))
                                .Add(Expression.Eq("ID", id));

            return criteria.UniqueResult<T>();
        }

        public List<T> GetAll()
        {
            ICriteria criteria = Session.CreateCriteria(typeof(T));
            return criteria.List<T>() as List<T>;
        }

        public List<T> FindAll(IDictionary<string, object> propertyValuePairs)
        {
            throw new System.NotImplementedException();
        }

        public T FindOne(IDictionary<string, object> propertyValuePairs)
        {
            throw new System.NotImplementedException();
        }

        public T SaveOrUpdate(T entity)
        {
            Session.Transaction.Begin();
            Session.SaveOrUpdate(entity);
            Session.Transaction.Commit();
            return entity;
        }

        public void Delete(T entity)
        {
            Session.Transaction.Begin();
            Session.Delete(entity);
            Session.Transaction.Commit();
        }

        public void Dispose()
        {
            if (Session.IsOpen)
                Session.Close();
        }
    }
}
