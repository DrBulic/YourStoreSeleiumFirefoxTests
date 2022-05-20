
using System.Threading;

namespace YourStorSeleniumFirefoxTests
{
    class DemoHelper
    {


        public static void Pause(int secondsToPause = 1000)
        {
            Thread.Sleep(secondsToPause);

        }
    }
}
