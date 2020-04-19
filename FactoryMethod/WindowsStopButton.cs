using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class WindowsStopButton : WindowsButton
    {
        public WindowsStopButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override void OnClick()
        {
            Console.WriteLine("Stop video...");
        }
    }
}
