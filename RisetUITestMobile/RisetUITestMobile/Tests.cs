using NUnit.Framework;
using Xamarin.UITest;

namespace RisetUITestMobile
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(Platform.Android);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            app.Screenshot("Welcome screen.");
            app.Tap("Blue");
            app.Screenshot("WelcomeTextIsDisplayed");
            //app.Repl();
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");

            //Assert.IsTrue(results.Any());
        }
    }
}
