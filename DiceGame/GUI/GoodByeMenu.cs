using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;

namespace DiceGame
{
   sealed class GoodByeMenu : Window
    {
        private TextBlock byeTextBlock;

        public GoodByeMenu() : base(0, 0, 120, 30, '%')
        {
            byeTextBlock = new TextBlock(10, 10, 100, new List<string> { "GOODBYE!!!" });
        }

        public override void Render()
        {
            base.Render();
            byeTextBlock.Render();
            Console.SetCursorPosition(0, 0);

        }
    }
}
