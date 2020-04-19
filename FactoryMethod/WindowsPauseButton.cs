using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class WindowsPauseButton : WindowsButton
    {
        public WindowsPauseButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override void OnClick()
        {
            Console.WriteLine("Pause video...");
        }
    }
}
