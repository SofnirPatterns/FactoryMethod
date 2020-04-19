using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class MacButton : Button
    {
        public MacButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override abstract void OnClick();

        protected override void AddHorizontalFrame()
        {
            ButtonWidget.Append('@', Text.Length + 2);
        }

        protected override void AddVerticalFrame()
        {
            ButtonWidget.Append($"\n@{Text}@\n");
        }
    }
}
