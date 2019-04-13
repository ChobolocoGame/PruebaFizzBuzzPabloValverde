
using NUnit.Framework;
using FizzBuzz.Services;
namespace FizzBuzz.Web.Tests.Controller
{
    [TestFixture]
    public class HomeControllerTests
    {
        private class DummyFizzBuzzService : IFizzBuzzService
        {
            public string Check(int number) { return "FizzBuzzDummyResult"; }
        }

        [Test]
        public void CanCreate()
        {
            var controller = new HomeControllerTests();
            Assert.IsNotNull(controller);
        }

       

        //[Test]
        //public void CheckReturnsCorrectView()
        //{
        //    var service = new DummyFizzBuzzService();
        //    var controller = new Controller(service);

        //    var result = (ViewResult)controller.Index();

        //    Assert.AreEqual("Index", result.ViewName);
        //}

        
    }
}
