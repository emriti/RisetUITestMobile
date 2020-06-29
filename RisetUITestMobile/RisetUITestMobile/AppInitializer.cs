using Xamarin.UITest;

namespace RisetUITestMobile
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                    .ApkFile("C:/Users/emriti/source/repos/Net/RisetUITestMobile/RisetUITestMobile/app-release.apk")
                    .DeviceSerial("emulator-5554")
                    .EnableLocalScreenshots()
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}