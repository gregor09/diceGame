using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;

namespace DiceGame
{
    class GameOver

    {
        private Button replayButton;
        private Button menuButton;
        private Button quitButton;

        public List<Button> buttons = new List<Button>();

        public GameOver()
        {
            replayButton = new Button(20, 20, 22, 5, "Press R for Replay");
            menuButton = new Button(50, 20, 22, 5, "Press M for Menu");
            quitButton = new Button(80, 20, 22, 5, "Press Q for Quit");

            AddButtonList();
        }

        private void AddButtonList()
        {
            buttons.Add(replayButton);
            buttons.Add(menuButton);
            buttons.Add(quitButton);
        }

        public void Render()
        {
            foreach (Button item in buttons)
            {
                item.Render();
            }

            Console.SetCursorPosition(0, 0);

        }
    }
}
