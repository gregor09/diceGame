using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;

namespace DiceGame.GUI
{
    class DiceSelectionMenu : Window
    {

        private TextBlock titleTextBlock;
        private TextBlock endTextBlock;
        private Frame diceFrame;
        

        public DiceSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 6, 100, new List<string> { "Please select number of dice using + and - keys:", "Min dice number is 1." });
            endTextBlock = new TextBlock(10, 20, 100, new List<string> { "Click ENTER to start game.", "Click ESC to Quit." });
            diceFrame = new Frame(55, 10, 9, 5, '*');
        }



        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();
            endTextBlock.Render();
            diceFrame.Render();

            Console.SetCursorPosition(0, 0);

        }



    }
}
