using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;

namespace DiceGame
{
    sealed class MainMenu : Window
    {
        private Button quitButton;
        private Button playButton;
        private TextBlock titleTextBlock;

        public List<Button> buttons = new List<Button>();

        public MainMenu() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Wellcome to DiceGame!"});

            playButton = new Button(25, 13, 25, 5, "Press P for Play");

            quitButton = new Button(70, 13, 25, 5, "Press Q for Quit");

            AddButtonList();
        }

        private void AddButtonList()
        {
            buttons.Add(playButton);
            buttons.Add(quitButton);
        }

        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();

            foreach (Button item in buttons)
            {
                item.Render();
            }

            Console.SetCursorPosition(0, 0);

        }
   

    }
}
