using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MacVideoPlayer : VideoPlayer
    {
        protected override List<Button> CreateButtons()
        {
            List<Button> buttons = new List<Button>();
            ButtonFactory buttonFactory = new ButtonFactory();
            buttons.Add(buttonFactory.CreateMacButton(Enums.MacButtonType.Play));
            buttons.Add(buttonFactory.CreateMacButton(Enums.MacButtonType.Stop));
            buttons.Add(buttonFactory.CreateMacButton(Enums.MacButtonType.Pause));
            return buttons;
        }
    }
}
