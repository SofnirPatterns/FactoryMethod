using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MacPlayButton : MacButton
    {
        public MacPlayButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override void OnClick()
        {
            Console.WriteLine("Play video...");
        }
    }
}
