using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ButtonFactory
    {
        public WindowsButton CreateWindowsButton(Enums.WindowsButtonType windowsButtonType)
        {
            switch (windowsButtonType)
            {
                case Enums.WindowsButtonType.Play:
                    return new WindowsPlayButton("Play", ConsoleKey.Enter);
                case Enums.WindowsButtonType.Stop:
                    return new WindowsStopButton("Stop", ConsoleKey.Escape);
                case Enums.WindowsButtonType.Pause:
                    return new WindowsPauseButton("Pause", ConsoleKey.Spacebar);
                default:
                    return null;
            }            
        }

        public MacButton CreateMacButton(Enums.MacButtonType macButtonType)
        {
            switch (macButtonType)
            {
                case Enums.MacButtonType.Play:
                    return new MacPlayButton("Play", ConsoleKey.Enter);
                case Enums.MacButtonType.Stop:
                    return new MacStopButton("Stop", ConsoleKey.Escape);
                case Enums.MacButtonType.Pause:
                    return new MacPauseButton("Pause", ConsoleKey.Spacebar);
                default:
                    return null;
            }
        }
    }
}
