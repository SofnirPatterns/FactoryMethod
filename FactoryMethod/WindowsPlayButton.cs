using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class WindowsPlayButton : WindowsButton
    {
        public WindowsPlayButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override void OnClick()
        {                                 
            Console.WriteLine("Play Video...");
        }
    }
}
