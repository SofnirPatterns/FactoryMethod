using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class WindowsVideoPlayer : VideoPlayer
    {
        protected override List<Button> CreateButtons()
        {
            List<Button> buttons = new List<Button>();
            ButtonFactory buttonFactory = new ButtonFactory();
            buttons.Add(buttonFactory.CreateWindowsButton(Enums.WindowsButtonType.Play));
            buttons.Add(buttonFactory.CreateWindowsButton(Enums.WindowsButtonType.Stop));
            buttons.Add(buttonFactory.CreateWindowsButton(Enums.WindowsButtonType.Pause));
            return buttons;
        }
    }
}
