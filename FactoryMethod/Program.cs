using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsVideoPlayer windowsVideoPlayer = new WindowsVideoPlayer();
            windowsVideoPlayer.Run();

            //MacVideoPlayer macVideoPlayer = new MacVideoPlayer();
            //macVideoPlayer.Run();
        }
    }
}
