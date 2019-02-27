using HelloAPI.Controllers;
using HelloService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Options;

namespace HelloTest
{
    [TestClass]
    public class TestHello
    {
        [TestMethod]
        public void TestHelloAPI_SayHello()
        {
            var apiOptions = Options.Create(new HelloAPI.Models.WriterConfig() { WriterClass = "HelloService.ConsoleWriter" });
            var controller = new HelloController(apiOptions);

            string msg = "Hello World!";
            var result = controller.SayHello(msg);
            Assert.AreEqual(msg, result);
         }

        [TestMethod]
        public void TestHelloService_Write()
        {
            IWriter Writer = new ConsoleWriter();

            bool result = Writer.Write("Test");
            Assert.IsTrue(result);
        }
    }
}
