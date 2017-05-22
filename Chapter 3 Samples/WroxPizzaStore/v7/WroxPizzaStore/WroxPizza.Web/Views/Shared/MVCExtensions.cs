using System.Web.Mvc;
using Microsoft.Web.Mvc;
using WroxPizza.Core.Web.Controllers;

namespace WroxPizza.Web.Views.Shared
{
    public static  class MVCExtensions
    {
        public static string CreateProductsMenuLink(this HtmlHelper html)
        {
            return html.ActionLink<ProductsMenuController>(c => c.Index(), "Menu");
        }

        public static string CreateOrdersLink(this HtmlHelper html)
        {
            return "Orders";
        }

        public static string GetRowClass(this HtmlHelper helper, int rowIndex)
        {
            return rowIndex % 2 == 0 ? "normal-row" : "alternate-row";
        }
    }
}
