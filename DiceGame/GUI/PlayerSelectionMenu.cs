using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;

namespace DiceGame
{
    sealed class PlayerSelectionMenu : Window
    {

        private Button p2Button;
        private Button p3Button;
        private Button p4Button;
        private Button p5Button;
        private Button p6Button;
        private Button p7Button;
        private TextBlock titleTextBlock;

        public List<Button> buttons = new List<Button>();
        private int activeButtonId = 2;

        public PlayerSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 4, 100, new List<string> { "Please select number of players:" });

            p2Button = new Button(45, 7, 10, 5, "P2");
            p2Button.SetActive();
            p2Button.ButtonId = 2;

            p3Button = new Button(65, 7, 10, 5, "P3");
            p3Button.ButtonId = 3;

            p4Button = new Button(45, 14, 10, 5, "P4");
            p4Button.ButtonId = 4;

            p5Button = new Button(65, 14, 10, 5, "P5");
            p5Button.ButtonId = 5;

            p6Button = new Button(45, 21, 10, 5, "P6");
            p6Button.ButtonId = 6;

            p7Button = new Button(65, 21, 10, 5, "P7");
            p7Button.ButtonId = 7;

            AddButtonList();
        }

        private void AddButtonList()
        {
            buttons.Add(p2Button);
            buttons.Add(p3Button);
            buttons.Add(p4Button);
            buttons.Add(p5Button);
            buttons.Add(p6Button);
            buttons.Add(p7Button);
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
        public void ActivateButtonById(int id)
        {
            foreach (Button item in buttons)
            {
                if (item.ButtonId == id)
                {
                    item.SetActive();
                    activeButtonId = id;
                }
                else
                {
                    item.Deactive();
                }
            }
            Render();
        }

        public int GetActiveButtonId()
        {
            return activeButtonId;
        }





    }
}
