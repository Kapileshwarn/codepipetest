using System.Web.Mvc;

namespace WroxPizza.Web.Views.Shared
{
    public static  class MVCExtensions
    {
        public static string GetRowClass(this HtmlHelper helper, int rowIndex)
        {
            return rowIndex % 2 == 0 ? "normal-row" : "alternate-row";
        }
    }
}
