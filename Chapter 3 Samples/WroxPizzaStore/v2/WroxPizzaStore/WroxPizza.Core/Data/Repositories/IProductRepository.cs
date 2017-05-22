using System.Collections.Generic;
using WroxPizza.Core.Model;

namespace WroxPizza.Core.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetAll();
    }
}
