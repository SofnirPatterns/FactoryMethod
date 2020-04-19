using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class VideoPlayer
    {
        public void Run()
        {
            Console.WriteLine();
            
            List<Button> buttons = CreateButtons();
            
            foreach (Button button in buttons)
            {
                button.Display();
                Console.WriteLine(button.ConsoleKey.ToString());
                Console.WriteLine();
            }

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey consoleKey = Console.ReadKey(true).Key;

                    foreach (Button button in buttons)
                    {
                        if (consoleKey == button.ConsoleKey)
                        {
                            button.OnClick();
                        }
                    }
                }
            }
        }

        protected abstract List<Button> CreateButtons();
    }
}
