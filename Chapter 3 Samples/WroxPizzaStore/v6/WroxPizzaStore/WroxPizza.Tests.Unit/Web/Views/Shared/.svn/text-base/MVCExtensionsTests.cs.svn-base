using System.Web.Mvc;
using NUnit.Framework;
using WroxPizza.Web.Views.Shared;

namespace WroxPizza.Tests.Unit.Web.Views.Shared
{
    [TestFixture]
    public class MVCExtensionsTests
    {
        HtmlHelper h;

        [SetUp]
        public void Setup()
        {
            h = MockHelper.CreateHtmlHelper();
        }

        [Test]
        public void GetRowClass_Returns_Normal_For_Even_Number()
        {
            string rowClass = h.GetRowClass(0);
            Assert.AreEqual("normal-row", rowClass); //CSS Style
        }


        [Test]
        public void GetRowClass_Returns_Alt_For_Odd_Number()
        {
            string rowClass = h.GetRowClass(1);
            Assert.AreEqual("alternate-row", rowClass); //CSS Style
        }
    }
}
