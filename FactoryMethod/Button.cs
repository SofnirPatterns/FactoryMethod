using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Button
    {
        public string Text { get; set; }
        protected StringBuilder ButtonWidget= new StringBuilder();
        public ConsoleKey ConsoleKey { get; set; }

        public Button(string text, ConsoleKey consoleKey)
        {            
            Text = text;
            ConsoleKey = consoleKey;

            if (!String.IsNullOrEmpty(text))
            {
                CreateWidget();
            }
        }

        public abstract void OnClick();

        public void Display()
        {
            Console.WriteLine(ButtonWidget);
        }

        protected abstract void AddHorizontalFrame();
        protected abstract void AddVerticalFrame();

        private void CreateWidget()
        {
            AddHorizontalFrame();
            AddVerticalFrame();            
            AddHorizontalFrame();
        }
    }
}
