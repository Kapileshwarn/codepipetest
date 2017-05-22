using FluentNHibernate.Mapping;
using WroxPizza.Core.Model;

namespace WroxPizza.Core.Data.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            WithTable("Products");
            Id(x => x.ID, "ProductId");
            Map(x => x.Name).CanNotBeNull();
            Map(x => x.Description).CanNotBeNull();
            Map(x => x.BasePrice).CanNotBeNull();
        }
    }
}
