using NUnit.Framework;

namespace coding_dojo_dotnetcore
{
    public class HelloWorldShould
    {

        HelloWorld helloWorld;

        [SetUp]
        public void Setup()
        {
            helloWorld = new HelloWorld();
        }

        [Test]
        public void ReturnHelloWorld()
        {
            Assert.AreEqual("Hello World!", helloWorld.helloWorld());
        }
    }
}