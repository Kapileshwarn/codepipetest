using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Rhino.Mocks;

namespace WroxPizza.Tests.Unit
{
    class MockHelper
    {
        public static HtmlHelper CreateHtmlHelper()
        {
            return new HtmlHelper(MockRepository.GenerateStub<ViewContext>(), MockRepository.GenerateStub<IViewDataContainer>());
        }

        public static HtmlHelper CreateHtmlHelper(HttpContextBase baseContext)
        {
            MockRepository m = new MockRepository();
            ControllerContext controllerContext = MockControllerContext(baseContext);
            ViewContext viewContext = m.Stub<ViewContext>(controllerContext,
                                                            m.Stub<IView>(),
                                                            new ViewDataDictionary(),
                                                            new TempDataDictionary());


            viewContext.HttpContext = baseContext;

            return new HtmlHelper(viewContext, m.Stub<IViewDataContainer>());
        }
        public static ControllerContext MockControllerContext(HttpContextBase baseContext)
        {
            return new ControllerContext(baseContext,
                                         new RouteData(),
                                         MockRepository.GenerateStub<ControllerBase>());
        }
    }
}
