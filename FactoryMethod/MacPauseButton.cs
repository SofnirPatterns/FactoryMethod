using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MacPauseButton : MacButton
    {
        public MacPauseButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override void OnClick()
        {
            Console.WriteLine("Pause video...");
        }
    }
}
