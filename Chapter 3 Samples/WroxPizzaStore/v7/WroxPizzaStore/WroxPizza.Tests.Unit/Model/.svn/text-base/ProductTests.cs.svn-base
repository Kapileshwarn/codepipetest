using NUnit.Framework;
using WroxPizza.Core.Model;

namespace WroxPizza.Tests.Unit.Model
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_Returns_Price_As_String_With_Dollar_Symbol()
        {
            Product p = new Product();
            p.BasePrice = 4.99;

            Assert.AreEqual("$4.99", p.GetPrice());
        }
    }
}