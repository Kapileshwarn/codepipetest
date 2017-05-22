using System.Web.Routing;
using WroxPizza.Core.Web.Setup;

namespace WroxPizza.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RoutesTable.RegisterRoutes(RouteTable.Routes);
        }
    }
}