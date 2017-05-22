using System.Web.Mvc;

namespace WroxPizza.Tests.Unit
{
    public static class MVCTestExtensions
    {
        public static T GetModel<T>(this ActionResult page) where T : class
        {
            return ((ViewResult) page).ViewData.Model as T;
        }
    }
}